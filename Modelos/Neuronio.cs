namespace BurriceArtificial.Modelos
{
    public class Neuronio
    {
        public double[] Pesos { get; }
        public double Bias { get; }

        public Neuronio(double[] pesos, double bias)
        {
            Pesos = pesos;
            Bias = bias;
        }

        private double Sigmoide(double x)
            => 1.0 / (1.0 + Math.Exp(-x));

        public string Decidir(double[] entradas)
        {
            if (entradas.Length != Pesos.Length)
                throw new ArgumentException("Tem mais entradas ou mais pesos");

            double soma = 0.0;

            for (int i = 0; i < entradas.Length; i++)
                soma += entradas[i] * Pesos[i];

            soma += Bias;

            double resultado = Sigmoide(soma);

            return resultado switch
            {
                <= 0.1 => "🧊 Tico: Nem sonha.",
                <= 0.3 => "🙅‍♂️ Tico: Não força.",
                <= 0.5 => "🤨 Tico: Tá na dúvida, hein...",
                <= 0.7 => "😬 Tico: A recaída vem aí.",
                <= 0.85 => "🍷 Tico: Só mais uma taça...",
                <= 0.95 => "🥴 Tico: Você já sabe né.",
                _ => "💬 Tico: Manda o 'Oi, sumida...'"
            };
        }
    }
}