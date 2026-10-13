using PostService.Dtos;
using PostService.Models;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace PostService.App
{
    public partial class PostingList : Form
    {
        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5000")
        };
        public PostingList()
        {
            InitializeComponent();
            gridPostings.AutoGenerateColumns = false;
        }

        private async Task LoadPostingsAsync()
        {
            try
            {
                var options = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var postings = await _httpClient.GetFromJsonAsync<PostingGetDto[]>("/postings");
                gridPostings.DataSource = postings;
                lblTtlСnt.Text = $"Всього записів: {postings?.Length ?? 0}";
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Не вдалося отримати дані з сервера. Перевірте, чи запущено PostService.");
            }

        }
        private async void PostingList_Load(object? sender, EventArgs e)
        {
            await LoadPostingsAsync();
        }
        private async void btnRefres_Click(object? sender, EventArgs e)
        {
            await LoadPostingsAsync();
        }
        private async void btnDelete_Click(object? sender, EventArgs e)
        {
            if (gridPostings.CurrentRow?.DataBoundItem is not PostingGetDto selectedPosting)
            {
                MessageBox.Show("Виберіть рядок.");
                return;
            }

            var response = await _httpClient.DeleteAsync($"/postings/{selectedPosting.Id}");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Помилка: {(int)response.StatusCode}");
                return;
            }

            await LoadPostingsAsync();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            using (var dlg = new PostingDialog(_httpClient))
            {
                if (dlg.ShowDialog() == DialogResult.OK) await Task.Delay(100); await LoadPostingsAsync();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (gridPostings.CurrentRow?.DataBoundItem is not PostingGetDto selectedPosting)
            {
                MessageBox.Show("Виберіть відправлення для редагування.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dlg = new PostingDialog(_httpClient, selectedPosting.Id))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    await Task.Delay(100);
                    await LoadPostingsAsync();
                }
            }
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (gridPostings.CurrentRow?.DataBoundItem is not PostingGetDto selectedPosting)
            {
                MessageBox.Show("Виберіть відправлення для перегляду деталей.");
                return;
            }
            using var dlg = new PostingDialog(_httpClient, selectedPosting.Id, isReadOnly: true);
            dlg.ShowDialog();
        }
    }

}
