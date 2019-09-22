using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EncurtadorDeLinksBitLy
{
    public partial class FrmEncurtador : Form
    {
        public FrmEncurtador()
        {
            InitializeComponent();
        }

        private async void BtnEncurtar_Click_1(object sender, EventArgs e)
        {
            if (txtUrlLonga.Text.Trim().Equals(string.Empty))
                return;

            string longUrl = txtUrlLonga.Text.Trim();

            BitLyAPI.BitLyAPI api = new BitLyAPI.BitLyAPI();
            txtURLEncurtada.Text = await api.ShortenAsync(longUrl);
        }

        private async void BtnEncurtarListasDeLinks_Click_1(object sender, EventArgs e)
        {
            string strEntrada = @"C:\Users\franc\source\repos\Csharp-EncurtadorLinksBitLy\EncurtadorDeLinksBitLy\EncurtadorDeLinksBitLy\Arquivos\Entrada.txt";
            string strSaida = @"C:\Users\franc\source\repos\Csharp-EncurtadorLinksBitLy\EncurtadorDeLinksBitLy\EncurtadorDeLinksBitLy\Arquivos\Saida.txt";

            if (File.Exists(strEntrada))
            {
                using (StreamReader sr = new StreamReader(strEntrada))
                {
                    var listLinks = new List<Link>();
                    string linha = string.Empty;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        if (!linha.Equals(string.Empty))
                        {
                            var oLink = new Link();
                            oLink.LongUrl = linha;
                            listLinks.Add(oLink);
                        }
                    }

                    BitLyAPI.BitLyAPI api = new BitLyAPI.BitLyAPI();

                    foreach (var item in listLinks)
                    {
                        item.ShortUrl = await api.ShortenAsync(item.LongUrl);
                    }

                    using (StreamWriter wr = new StreamWriter(strSaida, false))
                    {
                        foreach (var item in listLinks)
                        {
                            wr.WriteLine(item.ShortUrl);
                        }
                    }
                }
            }

            MessageBox.Show("Um processamento finalizado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
