using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using PostService.CommonTypes;
using PostService.Dtos;

namespace PostService.App
{
    public partial class PostingDialog : Form
    {
        private readonly HttpClient _httpClient;
        private readonly int? _id;

        public PostingDialog(HttpClient httpClient)
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
            _httpClient = httpClient;
            _id = null;
            this.Text = "Створити посилку";
            cmbDl.DataSource = Enum.GetValues(typeof(DeliveryType));
        }
        public PostingDialog(HttpClient httpClient, int id) : this(httpClient)
        {
            _id = id;
            this.Text = "Редагувати посилку";
            LoadPostingData(id);
        }
        public PostingDialog(HttpClient httpClient, int id, bool isReadOnly) : this(httpClient, id)
        {
            if (isReadOnly)
            {
                this.Text = "Деталі посилки";
                txtSnd.ReadOnly = true;
                txtRc.ReadOnly = true;
                txtCn.ReadOnly = true;
                cmbDl.Enabled = false;
                txtCs.ReadOnly = true;

                txtWgh.ReadOnly = true;
                txtWd.ReadOnly = true;
                txtHgh.ReadOnly = true;
                txtDp.ReadOnly = true;
                txtDlVl.ReadOnly = true;

                btnSave.Visible = false;
            }
        }
        private async void LoadPostingData(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/postings/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var p = await response.Content.ReadFromJsonAsync<PostingGetDto>();
                    if (p != null)
                    {
                        txtSnd.Text = p.From;
                        txtRc.Text = p.To;
                        txtCn.Text = p.Content;
                        cmbDl.SelectedItem = p.DeliveryType;
                        txtWgh.Text = p.Weight.ToString();
                        txtCs.Text = p.Value?.ToString() ?? "";

                        txtWd.Text = p.Width.ToString();
                        txtHgh.Text = p.Height.ToString();
                        txtDp.Text = p.Depth.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних: {ex.Message}");
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSnd.Text) || string.IsNullOrWhiteSpace(txtRc.Text))
            {
                MessageBox.Show("Заповніть обов'язкові поля: Відправник i Одержувач!");
                return;
            }
            float w = float.TryParse(txtWgh.Text, out var parsedW) ? parsedW : 0f;
            float? val = float.TryParse(txtCs.Text, out var parsedV) ? parsedV : null;

            float width = float.TryParse(txtWd.Text, out var parsedWd) ? parsedWd : 0f;
            float h = float.TryParse(txtHgh.Text, out var parsedH) ? parsedH : 0f;
            float d = float.TryParse(txtDp.Text, out var parsedD) ? parsedD : 0f;
            float dlVl = float.TryParse(txtDlVl.Text, out var parsedDlVl) ? parsedDlVl : 0f;
            var dt = cmbDl.SelectedItem is DeliveryType dType ? dType : DeliveryType.Department;

            if (_id == null)
            {
                var dto = new PostingPostDto { From = txtSnd.Text, To = txtRc.Text, 
                                               Content = txtCn.Text, DeliveryType = dt, 
                                               Weight = w, Value = val,
                                               Width = width, Height = h, Depth = d};
                var res = await _httpClient.PostAsJsonAsync("/postings", dto);
                if (!res.IsSuccessStatusCode)
                {
                    var errorDetails = await res.Content.ReadAsStringAsync();
                    MessageBox.Show($"Помилка створення: {(int)res.StatusCode} - {errorDetails}");
                    return;
                }
            }
            else
            {
                var dto = new PostingPutDto { Id = _id.Value, From = txtSnd.Text, 
                                              To = txtRc.Text, Content = txtCn.Text, 
                                              DeliveryType = dt, Weight = w, Value = val,
                                              Width = width, Height = h, Depth = d};
                var res = await _httpClient.PutAsJsonAsync($"/postings/{_id.Value}", dto);
                if (!res.IsSuccessStatusCode)
                {
                    var errorDetails = await res.Content.ReadAsStringAsync();
                    MessageBox.Show($"Помилка оновлення: {(int)res.StatusCode} - {errorDetails}");
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}