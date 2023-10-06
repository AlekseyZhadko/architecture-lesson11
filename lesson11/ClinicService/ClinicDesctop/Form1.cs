using ClinicServiceNamespace;

namespace ClinicDesctop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            ICollection<Client> clients = clinicClient.ClientGetAllAsync().Result;

            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                listViewClients.Items.Add(item);
            }


        }

        private void BtnCreateClient_Click(object sender, EventArgs e)
        {
            ClinicClient clinicClient = new ClinicClient("http://localhost:5076/", new HttpClient());
            int res = clinicClient.ClientCreateAsync(Update(new Client
            {
                Document = textDocument.Text,
                SurName = textSurname.Text,
                FirstName = textLastname.Text,
                Patronymic = textPatronymic.Text,
                Birthday = DateTime.Now
            })
            ).Result;
        }
    }

    public partial class Sample
    {
        public int a;
    }
}