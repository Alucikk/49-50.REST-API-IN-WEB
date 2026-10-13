// Початковий масив із трьома картками за замовчуванням, коли ми працюємо в додатку
let shipments = [
  {
    id: 1,
    sender: "Олександр Коваленко",
    receiver: "Марія Петренко",
    content: "Електроніка (ноутбук)",
    deliveryType: "Стандарт",
    weight: "2.5 кг",
    dimensions: "35x25x5 см",
    declaredValue: "150 грн",
    deliveryCost: "55.00 грн",
    status: "У ДОРОЗІ"
  },
  {
    id: 2,
    sender: "ТОВ 'ТехноСвіт'",
    receiver: "Іван Сидоренко",
    content: "Документи",
    deliveryType: "Стандарт",
    weight: "0.3 кг",
    dimensions: "20x15x2 см",
    declaredValue: "60 грн",
    deliveryCost: "33.00 грн",
    status: "У ДОРОЗІ"
  },
  {
    id: 3,
    sender: "Олена Гнатюк",
    receiver: "Дмитро Мельник",
    content: "Одяг та взуття",
    deliveryType: "Стандарт",
    weight: "5.0 кг",
    dimensions: "40x30x20 см",
    declaredValue: "120 грн",
    deliveryCost: "80.00 грн",
    status: "У ДОРОЗІ"
  }
];
//Глобальні змінні для роботи форми і ід для редагування
let currentMode = 'create';
let editingId = null;
//адреса для роботи з сервером
const API_URL = 'http://localhost:5000/postings';

// Точний розрахунок вартості
function calculatePostingPrice(weightStr, deliveryType) {
  let baseRate = 30.0;
  if (deliveryType === 'ExpressCourier' || deliveryType.includes('експрес') || deliveryType.includes('Кур\'єр')) {
    baseRate = 60.0;
  }
  const weightNum = parseFloat(weightStr) || 0;
  return baseRate + (weightNum * 10.0);
}
//Завантаження даниз з сервера чи робота з локальними даними
async function loadData() {
  try {
    const response = await fetch(API_URL);
    if (!response.ok) throw new Error('Помилка сервера');
    const data = await response.json();
    
    if (data && data.length > 0) {
      shipments = data.map((item, index) => {
        const wStr = item.weight ? item.weight.toString() : '2.5';
        const dType = item.deliveryType || 'Стандарт';
        const calculatedPrice = item.price !== undefined ? item.price : calculatePostingPrice(wStr, dType);

        return {
          id: item.id || index + 1,
          sender: item.from || item.sender || 'Не вказано',
          receiver: item.to || item.receiver || 'Не вказано',
          content: item.content || 'Без вмісту',
          deliveryType: dType,
          weight: (item.weight ? item.weight + ' кг' : '0 кг'),
          dimensions: `${item.width || 0}x${item.height || 0}x${item.depth || 0} см`,
          declaredValue: (item.value ? item.value + ' грн' : '0 грн'),
          deliveryCost: calculatedPrice.toFixed(2) + ' грн',
          status: "У ДОРОЗІ"
        };
      });
    }
  } catch (error) {
    console.log('Працюємо на локальних даних:', error);
  }
  renderShipmentsList();
}
//Функція для перемикання екранів
function showScreen(screenId) {
  const screens = document.querySelectorAll('.screen');
  screens.forEach(screen => {
    screen.style.display = 'none';
  });
  const target = document.getElementById(screenId);
  if (target) {
    target.style.display = 'flex';
  }
}
//Функція для відкриття форми створення або редагування
function openShipmentForm(mode, id = null) {
  currentMode = mode;
  editingId = id;
  
  const titleElement = document.querySelector('#create-screen .sub-header-title');
  const senderInput = document.getElementById('form-sender');
  const receiverInput = document.getElementById('form-receiver');
  const contentInput = document.getElementById('form-content');
  const deliveryInput = document.getElementById('form-delivery');
  const weightInput = document.getElementById('form-weight');
  const dimensionsInput = document.getElementById('form-dimensions');
  const valueInput = document.getElementById('form-value');

  resetValidationUI();

  if (mode === 'create') {
    if (titleElement) titleElement.textContent = 'Нове відправлення';
    if (senderInput) senderInput.value = '';
    if (receiverInput) receiverInput.value = '';
    if (contentInput) contentInput.value = '';
    if (deliveryInput) deliveryInput.value = '';
    if (weightInput) weightInput.value = '';
    if (dimensionsInput) dimensionsInput.value = '';
    if (valueInput) valueInput.value = '';
  } else if (mode === 'edit') {
    if (titleElement) titleElement.textContent = 'Редагування відправлення';
    
    const data = shipments.find(s => String(s.id) === String(id)) || {};

    if (senderInput) senderInput.value = data.sender || '';
    if (receiverInput) receiverInput.value = data.receiver || '';
    if (contentInput) contentInput.value = data.content || '';
    if (deliveryInput) deliveryInput.value = data.deliveryType || '';
    if (weightInput) weightInput.value = data.weight || '';
    if (dimensionsInput) dimensionsInput.value = data.dimensions || '';
    if (valueInput) valueInput.value = data.declaredValue || '';
  }

  showScreen('create-screen');
}
//Збереження чи оновлення відправлення з перевірками валідації
function saveShipment() {
  if (!validateFormLive(true)) {
    return; 
  }

  const sender = document.getElementById('form-sender').value;
  const receiver = document.getElementById('form-receiver').value;
  const content = document.getElementById('form-content').value;
  const deliveryType = document.getElementById('form-delivery').value;
  const weight = document.getElementById('form-weight').value;
  const dimensions = document.getElementById('form-dimensions').value;
  const declaredValue = document.getElementById('form-value').value;

  // Розрахунок вартості
  const calculatedPrice = calculatePostingPrice(weight, deliveryType);
  const deliveryCost = calculatedPrice.toFixed(2) + ' грн';

  if (currentMode === 'create') {
    const newShipment = {
      id: Date.now(),
      sender,
      receiver,
      content,
      deliveryType,
      weight,
      dimensions,
      declaredValue,
      deliveryCost,
      status: "У ДОРОЗІ"
    };
    shipments.push(newShipment);
  } else if (currentMode === 'edit') {
    const index = shipments.findIndex(s => String(s.id) === String(editingId));
    if (index !== -1) {
      shipments[index] = {
        ...shipments[index],
        sender,
        receiver,
        content,
        deliveryType,
        weight,
        dimensions,
        declaredValue,
        deliveryCost
      };
    }
  }

  renderShipmentsList();
  showScreen('list-screen');
}
//Скасування заповнення форми і повернення до списку
function cancelForm() {
  showScreen('list-screen');
}
//Екран деталей для конкретної картки
function openDetails(id) {
  const item = shipments.find(s => String(s.id) === String(id));
  if (!item) return;
  
  editingId = id; 

  const detailSender = document.getElementById('detail-sender');
  const detailReceiver = document.getElementById('detail-receiver');
  const detailContent = document.getElementById('detail-content');
  const detailDelivery = document.getElementById('detail-delivery');
  const detailWeight = document.getElementById('detail-weight');
  const detailDimensions = document.getElementById('detail-dimensions');
  const detailValue = document.getElementById('detail-value');
  const detailCost = document.getElementById('detail-cost');

  if (detailSender) detailSender.textContent = item.sender;
  if (detailReceiver) detailReceiver.textContent = item.receiver;
  if (detailContent) detailContent.textContent = item.content;
  if (detailDelivery) detailDelivery.textContent = item.deliveryType;
  if (detailWeight) detailWeight.textContent = item.weight;
  if (detailDimensions) detailDimensions.textContent = item.dimensions;
  if (detailValue) detailValue.textContent = item.declaredValue;
  // Виводимо реально розраховану вартість доставки окремо від цінності
  if (detailCost) detailCost.textContent = item.deliveryCost || calculatePostingPrice(item.weight, item.deliveryType).toFixed(2) + ' грн';

  showScreen('details-screen');
}

// Динамічний рендеринг карток та кнопки Створити
function renderShipmentsList() {
  const container = document.querySelector('#list-screen .scroll-content');
  if (!container) return;

  let html = '';
  shipments.forEach(item => {
// Якщо у початкових об'єктів ще не було deliveryCost, розраховуємо його динамічно
    const displayCost = item.deliveryCost || calculatePostingPrice(item.weight, item.deliveryType).toFixed(2) + ' грн';
//Динамічна генерація і виведення карточок на екрані списку
    html += `
      <div class="card" onclick="openDetails('${item.id}')">
        <div class="card-row">
          <span class="card-party">
            <svg width="12" height="12" viewBox="0 0 24 24" fill="none" stroke="#004d33" stroke-width="2"><path d="M20 21v-2a4 4 0 0 0-4-4H8a4 4 0 0 0-4 4v2"/><circle cx="12" cy="7" r="4"/></svg>
            ВІДПРАВНИК<br><b>${item.sender}</b>
          </span>
          <span class="card-party">
            <svg width="12" height="12" viewBox="0 0 24 24" fill="none" stroke="#004d33" stroke-width="2"><path d="M21 10c0 7-9 13-9 13s-9-6-9-13a9 9 0 0 1 18 0z"/><circle cx="12" cy="10" r="3"/></svg>
            ОТРИМУВАЧ<br><b>${item.receiver}</b>
          </span>
        </div>
        <div class="card-content-row">
          <svg width="13" height="13" viewBox="0 0 24 24" fill="none" stroke="#004d33" stroke-width="2">
            <path d="M21 16V8a2 2 0 0 0-1-1.73l-7-4a2 2 0 0 0-2 0l-7 4A2 2 0 0 0 3 8v8a2 2 0 0 0 1 1.73l7 4a2 2 0 0 0 2 0l7-4A2 2 0 0 0 21 16z"/>
            <polyline points="3.27 6.96 12 12.01 20.73 6.96"/>
            <line x1="12" y1="22.08" x2="12" y2="12"/>
          </svg>
          <span>ВМІСТ<br><b>${item.content}</b></span>
        </div>
        <div class="card-footer-row">
          <span>ВАГА<br><b>${item.weight}</b></span>
          <span>ВАРТІСТЬ<br><b>${displayCost}</b></span>
          <span class="badge">${item.status}</span>
          <button class="btn-delete-icon" onclick="event.stopPropagation(); openDeleteModal('${item.id}');" title="Видалити">
            <svg width="16" height="16" viewBox="0 0 24 24" fill="none" stroke="#d32f2f" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><polyline points="3 6 5 6 21 6"></polyline><path d="M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2"></path></svg>
          </button>
        </div>
      </div>
    `;
  });
  // Кнопка створення в кінці списку
  html += `
    <div style="display: flex; justify-content: flex-end; margin-top: 10px; margin-bottom: 20px;">
      <button class="btn-create" onclick="openShipmentForm('create')">
        <svg width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2.5" style="vertical-align: middle; margin-right: 4px;">
          <line x1="12" y1="5" x2="12" y2="19"></line><line x1="5" y1="12" x2="19" y2="12"></line>
        </svg>
        СТВОРИТИ
      </button>
    </div>
  `;

  container.innerHTML = html;
}
//Збереження ід відправлення для цого видалення
let deletingId = null;
//Модальне вікно підтвердження видалення
function openDeleteModal(id) {
  deletingId = id;
  const modal = document.getElementById('delete-modal');
  if (modal) modal.style.display = 'flex';
}
//Закриття цього модального вікна
function closeDeleteModal() {
  deletingId = null;
  const modal = document.getElementById('delete-modal');
  if (modal) modal.style.display = 'none';
}
//Підтвердження і видалення елемента з масиву
function confirmDelete() {
  if (deletingId !== null) {
    shipments = shipments.filter(s => String(s.id) !== String(deletingId));
    renderShipmentsList();
  }
  closeDeleteModal();
}
//Встановлення помилки для візуального стану відповідного поля
function setFieldStatus(wrapperId, errorTextId, hasError, showErrors) {
  const wrapper = document.getElementById(wrapperId)?.closest('.input-wrapper');
  const errorText = document.getElementById(errorTextId);
  
  if (hasError && showErrors) {
    if (wrapper) wrapper.classList.add('input-error');
    if (errorText) errorText.classList.add('visible');
  } else {
    if (wrapper) wrapper.classList.remove('input-error');
    if (errorText) errorText.classList.remove('visible');
  }
}
//Перевірка заповнення полів і валідності всієї форми
function validateFormLive(showErrors = false) {
  const senderVal = document.getElementById('form-sender')?.value.trim() || '';
  const receiverVal = document.getElementById('form-receiver')?.value.trim() || '';
  const contentVal = document.getElementById('form-content')?.value.trim() || '';
  const deliveryVal = document.getElementById('form-delivery')?.value.trim() || '';
  const weightVal = document.getElementById('form-weight')?.value.trim() || '';
  const dimensionsVal = document.getElementById('form-dimensions')?.value.trim() || '';
  const valueVal = document.getElementById('form-value')?.value.trim() || '';

  const isSenderValid = senderVal.length >= 3;
  const isReceiverValid = receiverVal.length >= 3;
  const isContentValid = contentVal.length > 0;
  const isDeliveryValid = deliveryVal.length > 0;
  const isWeightValid = weightVal.length > 0;
  const isDimensionsValid = dimensionsVal.length > 0;
  const isValueValid = valueVal.length > 0;

  setFieldStatus('form-sender', 'form-sender-error', !isSenderValid, showErrors);
  setFieldStatus('form-receiver', 'form-receiver-error', !isReceiverValid, showErrors);
  setFieldStatus('form-content', 'form-content-error', !isContentValid, showErrors);
  setFieldStatus('form-delivery', 'form-delivery-error', !isDeliveryValid, showErrors);
  setFieldStatus('form-weight', 'form-weight-error', !isWeightValid, showErrors);
  setFieldStatus('form-dimensions', 'form-dimensions-error', !isDimensionsValid, showErrors);
  setFieldStatus('form-value', 'form-value-error', !isValueValid, showErrors);

  const allValid = isSenderValid && isReceiverValid && isContentValid && isDeliveryValid && isWeightValid && isDimensionsValid && isValueValid;

  const statusBox = document.getElementById('formStatusBox');
  const statusDesc = document.getElementById('formStatusDesc');

  if (statusBox && statusDesc) {
    if (allValid) {
      statusBox.classList.remove('error');
      statusBox.classList.add('success');
      statusDesc.textContent = 'Готово до збереження';
    } else if (showErrors) {
      statusBox.classList.remove('success');
      statusBox.classList.add('error');
      statusDesc.textContent = 'Виправте помилки у формі';
    }
  }

  return allValid;
}
//Скидання помилок в інтерфейсі валідації
function resetValidationUI() {
  const inputs = ['form-sender', 'form-receiver', 'form-content', 'form-delivery', 'form-weight', 'form-dimensions', 'form-value', 'form-cost'];
  inputs.forEach(id => {
    const el = document.getElementById(id);
    if (el) {
      el.closest('.input-wrapper')?.classList.remove('input-error');
      const err = document.getElementById(id + '-error');
      if (err) err.classList.remove('visible');
    }
  });

  const statusBox = document.getElementById('formStatusBox');
  const statusDesc = document.getElementById('formStatusDesc');
  if (statusBox && statusDesc) {
    statusBox.classList.remove('error');
    statusBox.classList.add('success');
    statusDesc.textContent = 'Готово до збереження';
  }
}
//Ініціалізація слухачів подій після завантаження ДОМ-дерева
document.addEventListener('DOMContentLoaded', () => {
  const formInputs = document.querySelectorAll('#create-screen .form-input');
  formInputs.forEach(input => {
    input.addEventListener('input', () => {
      validateFormLive(true);
    });
  });
  loadData();
});