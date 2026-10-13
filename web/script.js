async function loadData() {
    const response = await fetch('http://localhost:5000/postings');

    if (!response.ok) {
        throw new Error('Сервер повернув помилку, try again: ' + response.status);
    }

    const data = await response.json();
    console.log(data); 
    return data;
}
loadData();

function renderTable(data) {
    const tableBody = document.getElementById('postings');
    const tableHeader = document.getElementById('table-header');
    tableBody.innerHTML = '';

    const columns = tableHeader.querySelectorAll('th');

    for (const posting of data) {
        const row = document.createElement('tr');

        for (const column of columns) {
            const fieldName = column.getAttribute('x-column');
            const cell = createCell(fieldName, posting);
            row.appendChild(cell);
        }

        tableBody.appendChild(row);
    }
}

function createCell(fieldName, model) {
    const cell = document.createElement('td');
    cell.textContent = model[fieldName];
    return cell;
}
function refreshThen() {
    const statusEl = document.getElementById('status');
    statusEl.textContent = 'Завантаження відправлень.';

    fetch('http://localhost:5000/postings')
        .then(response => {
            if (!response.ok) {
                throw new Error('Сервер повернув помилку: ' + response.status);
            }
            return response.json();
        })
        .then(data => {
            console.log(data);
            renderTable(data);
            statusEl.textContent = '';
        })
        .catch(error => {
            console.error('Помилка:', error);
            statusEl.textContent = 'Не вдалося завантажити дані відправлень, try again';
        });
}
/*renderTable([
    { content: 'Костюм теплий', from: 'Черкаси', to: 'Рівне', deliveryType: 1, weight: 2.0 },
    { content: 'Помада', from: 'Мукачево', to: 'Клевань', deliveryType: 1, weight: 0.6 }
]);*/
refreshThen()
