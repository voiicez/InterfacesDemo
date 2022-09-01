using InterfacesDemo2.Services.Bases;
using InterfacesDemo2.Services;
namespace InterfacesDemo2
{
    public partial class Form1 : Form
    {

        IKosesizHesaplaService _kosesizHesapService = new DarieHesaplaService();
        IKoseliHesaplaService _koseliHesaplaService;
        
        
            

        public Form1()
        {
            InitializeComponent();
            
        }

        private void cbdeneme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bKosesizHesapla_Click(object sender, EventArgs e)
        {
            
            double alan = _kosesizHesapService.AlanHesapla(Convert.ToDouble(tbYaricap.Text.Trim()));
            double cevre = _kosesizHesapService.CevreHesapla(Convert.ToDouble(tbYaricap.Text.Trim()));
            MessageBox.Show($"Alan: {alan} \n Çevre: {cevre}");
            
                
            
        }

        private void bKoseliHesapla_Click(object sender, EventArgs e)
        {

            if (comb1.SelectedIndex == 1)
            {
                _koseliHesaplaService = new DikdortgenHesaplaService();
               
            }

            else if (comb1.SelectedIndex == 0)
            {
                _koseliHesaplaService = new DikUcgenHesaplaService();
               
            }
            double alan = _koseliHesaplaService.AlanHesapla(Convert.ToDouble(tbTaban.Text.Trim()), Convert.ToDouble(tbYukseklik.Text.Trim()));
            double cevre = _koseliHesaplaService.CevreHesapla(Convert.ToDouble(tbYukseklik.Text.Trim()), Convert.ToDouble(tbTaban.Text.Trim()));
            MessageBox.Show($"Alan: {alan} Çevre: {cevre}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sekiller = new string[]
            {
                "Dik Üçgen","Dikdörtgen"
            };
            comb1.DataSource = sekiller;
        }
    }

    

}