using BurriceArtificial.Modelos;

namespace BurriceArtificial
{
    public partial class MainPage : ContentPage
    {
        private Neuronio neuronioTico;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            double carencia = sliderCarencia.Value;
            double alcool = sliderAlcool.Value;
            double amor = sliderAmorProprio.Value;

            neuronioTico = new Neuronio(new double[] { 1.5, 1.8, -3.0 }, -4.0);
            string decisao = neuronioTico.Decidir(new double[] { carencia, alcool, amor });

            lblResultado.Text = decisao;
        }

        private void SliderCarencia_Changed(object sender, ValueChangedEventArgs e)
        {
            double v = e.NewValue;
            string descricao = v switch
            {
                <= 1 => "Coração blindado",
                <= 2 => "Firme como uma rocha",
                <= 3 => "Sente falta, mas passa",
                <= 4 => "Leve vazio no peito",
                <= 5 => "Rolando os stories em silêncio",
                <= 6 => "Revendo fotos antigas",
                <= 7 => "Ouvindo sertanejo romântico",
                <= 8 => "Chorando com filme bobo",
                <= 9 => "Tocando 'Boate Azul'",
                _ => "Dormiu abraçado no travesseiro"
            };

            lblCarenciaDescricao.Text = $"Carência: nível {v:0} – {descricao}";
        }

        private void SliderAlcool_Changed(object sender, ValueChangedEventArgs e)
        {
            double v = e.NewValue;
            string descricao = v switch
            {
                <= 1 => "Só na água com gás",
                <= 2 => "Um vinho no jantar",
                <= 3 => "Tímido, mas sorrindo mais",
                <= 4 => "Falante e com brilho nos olhos",
                <= 5 => "Passinho já saiu",
                <= 6 => "Risada sem filtro",
                <= 7 => "Cantando no karaokê",
                <= 8 => "Dançando com o poste",
                <= 9 => "Subiu na mesa com copo na mão",
                _ => "Dormiu abraçado na garrafa"
            };

            lblAlcoolDescricao.Text = $"Álcool: nível {v:0} – {descricao}";
        }

        private void SliderAmorProprio_Changed(object sender, ValueChangedEventArgs e)
        {
            double v = e.NewValue;
            string descricao = v switch
            {
                <= 1 => "Autoestima evaporou",
                <= 2 => "Espelho virou inimigo",
                <= 3 => "Busca validação até do Wi-Fi",
                <= 4 => "Se valoriza... mas sofre",
                <= 5 => "Confuso, mas tentando",
                <= 6 => "Se olha com mais carinho",
                <= 7 => "Curtindo a própria companhia",
                <= 8 => "Postando frases motivacionais",
                <= 9 => "Pleno, tomando café e meditando",
                _ => "Blindado tipo coach de Instagram"
            };

            lblAmorProprioDescricao.Text = $"Amor próprio: nível {v:0} – {descricao}";
        }
    }
}