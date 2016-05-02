using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void EspressodrikkeKnap_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = true;
        }

        private void KaffeOgChokoladeKnap_Click(object sender, EventArgs e)
        {
            KaffeChokoladeMenu.Visible = true;
        }

        private void TeOgTedrikkeKnap_Click(object sender, EventArgs e)
        {
            TeogTeDrikkeMenu.Visible = true;
        }

        private void IceblendKnap_Click(object sender, EventArgs e)
        {
            IceblendMenu.Visible = true;;
        }

        private void MestTilMorgenKnap_Click(object sender, EventArgs e)
        {
            MestMorgenMenu.Visible = true;
        }

        private void MestTilFrokostKnap_Click(object sender, EventArgs e)
        {
            MestFrokostMenu.Visible = true;
        }

        private void MestTilEftermiddagKnap_Click(object sender, EventArgs e)
        {
            MestEftermiddagMenu.Visible = true;
        }

        private void EspressoKnap_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = false;
            Espresso.Visible = true;
        }

        private void CLatteKnap_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = false;
            Caffélatte.Visible = true;
        }

        private void CappuccinoKnap_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = false;
            Cappuccino.Visible = true;
        }

        private void EspressoTilStart_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = false;
            Espresso.Visible = false;
        }

        private void KlassiskFilterkaffeKnap_Click(object sender, EventArgs e)
        {
            KaffeChokoladeMenu.Visible = false;
            Klassiskfilterkaffe.Visible = true;
        }


        private void ChokoLatteKnap_Click(object sender, EventArgs e)
        {
            KaffeChokoladeMenu.Visible = false;
            Chokolatte.Visible = true;
        }

        private void TiramisuLatteKnap_Click(object sender, EventArgs e)
        {
            KaffeChokoladeMenu.Visible = false;
            Tiramisulatte.Visible = true;
        }

        private void KaffeChoTilStart_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = false;
            KaffeChokoladeMenu.Visible = false;
        }

        private void BaressoTeKnap_Click(object sender, EventArgs e)
        {
            TeogTeDrikkeMenu.Visible = false;
            BaressoTe.Visible = true;
        }

        private void ChaicinoKnap_Click(object sender, EventArgs e)
        {
            TeogTeDrikkeMenu.Visible = false;
            Chaicino.Visible = true;
        }

        private void IsteKnap_Click(object sender, EventArgs e)
        {
            TeogTeDrikkeMenu.Visible = false;
            Iste.Visible = true;
        }

        private void TeTilStart_Click(object sender, EventArgs e)
        {
            TeogTeDrikkeMenu.Visible = false;
        }

        private void DenOriginaleKnap_Click(object sender, EventArgs e)
        {
            IceblendMenu.Visible = false;
            DenOriginale.Visible = true;
        }

        private void DenUltimativeKnap_Click(object sender, EventArgs e)
        {
            IceblendMenu.Visible = false;
            DenUltimative.Visible = true;
        }

        private void SmooteaKnap_Click(object sender, EventArgs e)
        {
            IceblendMenu.Visible = false;
            Smootea.Visible = true;
        }

        private void IceblendTilStart_Click(object sender, EventArgs e)
        {
            IceblendMenu.Visible = false;
        }

        private void SkyrKnap_Click(object sender, EventArgs e)
        {
            MestMorgenMenu.Visible = false;
            Skyr.Visible = true;
        }

        private void FriskJuiceKnap_Click(object sender, EventArgs e)
        {
            MestMorgenMenu.Visible = false;
            FriskJuiceFraValsølille.Visible = true;
        }

        private void CroissanterKnap_Click(object sender, EventArgs e)
        {
            MestMorgenMenu.Visible = false;
            Croissanter.Visible = true;
        }

        private void MestMorTilStart_Click(object sender, EventArgs e)
        {
            MestMorgenMenu.Visible = false;
        }

        private void PanSalWrapKnap_Click(object sender, EventArgs e)
        {
            MestFrokostMenu.Visible = false;
            PaniniSalaterOgWrap.Visible = true;
        }

        private void FocacciaKnap_Click(object sender, EventArgs e)
        {
            MestFrokostMenu.Visible = false;
            Focaccia.Visible = true;
        }

        private void PastaKnap_Click(object sender, EventArgs e)
        {
            MestFrokostMenu.Visible = false;
            Pasta.Visible = true;
        }

        private void MestFroTilStart_Click(object sender, EventArgs e)
        {
            MestFrokostMenu.Visible = false;
        }

        private void SconesKnap_Click(object sender, EventArgs e)
        {
            MestEftermiddagMenu.Visible = false;
            Scones.Visible = true;
        }

        private void MuffinsKnap_Click(object sender, EventArgs e)
        {
            MestEftermiddagMenu.Visible = false;
            Muffins.Visible = true;
        }

        private void BrowniesKnap_Click(object sender, EventArgs e)
        {
            MestEftermiddagMenu.Visible = false;
            Brownies.Visible = true;
        }

        private void EsprTilEsprDrik_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = true;
            Espresso.Visible = false;
        }

        private void CLatteTilEsprDrik_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = true;
            Caffélatte.Visible = false;
        }

        private void CappuTilEsprDrikke_Click(object sender, EventArgs e)
        {
            EspressodrikkeMenu.Visible = true;
            Cappuccino.Visible = false;
        }

        private void KlaFilTilKaffeCho_Click(object sender, EventArgs e)
        {
            KaffeChokoladeMenu.Visible = true;
            Klassiskfilterkaffe.Visible = false; 
        }

        private void ChLatteTilKaffeCh_Click(object sender, EventArgs e)
        {
            KaffeChokoladeMenu.Visible = true;
            Chokolatte.Visible = false;
        }

        private void TiraLatteTilKaffeCh_Click(object sender, EventArgs e)
        {
            KaffeChokoladeMenu.Visible = true;
            Tiramisulatte.Visible = false;
        }

        private void BaressoTeTilTe_Click(object sender, EventArgs e)
        {
            TeogTeDrikkeMenu.Visible = true;
            BaressoTe.Visible = false;
        }

        private void MestEfterTilStart_Click(object sender, EventArgs e)
        {
            MestEftermiddagMenu.Visible = false;
        }

        private void ChaiTilTe_Click(object sender, EventArgs e)
        {
            TeogTeDrikkeMenu.Visible = true;
            Chaicino.Visible = false;
        }

        private void IsTeTilTe_Click(object sender, EventArgs e)
        {
            TeogTeDrikkeMenu.Visible = true;
            Iste.Visible = false;
        }

        private void DenOrigTilIceblend_Click(object sender, EventArgs e)
        {
            IceblendMenu.Visible = true;
            DenOriginale.Visible = false;
        }

        private void DenUltTilIceblend_Click(object sender, EventArgs e)
        {
            IceblendMenu.Visible = true;
            DenUltimative.Visible = false;
        }

        private void SmooTilIceblend_Click(object sender, EventArgs e)
        {
            IceblendMenu.Visible = true;
            Smootea.Visible = false;
        }

        private void SkyrTilMestM_Click(object sender, EventArgs e)
        {
            MestMorgenMenu.Visible = true;
            Skyr.Visible = false;
        }

        private void FriskJuiceTilMestM_Click(object sender, EventArgs e)
        {
            MestMorgenMenu.Visible = true;
            FriskJuiceFraValsølille.Visible = false;
        }

        private void CroisTilMestM_Click(object sender, EventArgs e)
        {
            MestMorgenMenu.Visible = true;
            Croissanter.Visible = false;
        }

        private void PanSalWrapTilMestFro_Click(object sender, EventArgs e)
        {
            MestFrokostMenu.Visible = true;
            PaniniSalaterOgWrap.Visible = false;
        }

        private void FocTilMestFro_Click(object sender, EventArgs e)
        {
            MestFrokostMenu.Visible = true;
            Focaccia.Visible = false;
        }

        private void PastaTilMestFro_Click(object sender, EventArgs e)
        {
            MestFrokostMenu.Visible = true;
            Pasta.Visible = false;
        }

        private void SconesTilMestEfter_Click(object sender, EventArgs e)
        {
            MestEftermiddagMenu.Visible = true;
            Scones.Visible = false;
        }

        private void MuffinsTilMestEfter_Click(object sender, EventArgs e)
        {
            MestEftermiddagMenu.Visible = true;
            Muffins.Visible = false;
        }

        private void BrowTilMestEfter_Click(object sender, EventArgs e)
        {
            MestEftermiddagMenu.Visible = true;
            Brownies.Visible = false;
        }
    }
}
