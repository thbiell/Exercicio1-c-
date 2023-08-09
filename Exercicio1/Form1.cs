namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qtdHomens = int.Parse(txtHomens.Text);
            int qtdMulheres = int.Parse(txtMulheres.Text);
            int qtdCriancas = int.Parse(txtCriancas.Text);

            double carneHomem = qtdHomens * 0.5;
            double carneMulher = qtdMulheres * 0.3;
            double carneCrianca = qtdCriancas * 0.15;

            double saladaHomem = qtdHomens * 0.1;
            double saladaMulher = qtdMulheres * 0.1;
            double saladaCrianca = qtdCriancas * 0.05;

            double farofaHomem = qtdHomens * 0.1;
            double farofaMulher = qtdMulheres * 0.1;
            double farofaCrianca = qtdCriancas * 0.05;

            double cervejaHomem = qtdHomens * 2;
            double cervejaMulher = qtdMulheres * 1;
            double cervejaCrianca = 0;

            double refriHomem = qtdHomens * 1;
            double refriMulher = qtdMulheres * 1.5;
            double refriCrianca = qtdCriancas * 1.5;

            double geloHomem = qtdHomens * 1;
            double geloMulher = qtdMulheres * 1;
            double geloCrianca = qtdCriancas * 0.5;

            double totalCarne = carneHomem + carneMulher + carneCrianca;
            double carvaoSacos = Math.Ceiling(totalCarne / 1);
            double carvaoKg = carvaoSacos * 1.5;

            lblCarne.Text = $"CARNE: \nHomens: {carneHomem:F2} kg       Mulheres: {carneMulher:F2} kg       Crianças: {carneCrianca:F2} kg";
            lblSalada.Text = $"SALADA: \nHomens: {saladaHomem:F2} kg       Mulheres: {saladaMulher:F2} kg       Crianças: {saladaCrianca:F2} kg";
            lblFarofa.Text = $"FAROFA: \nHomens: {farofaHomem:F2} kg       Mulheres: {farofaMulher:F2} kg       Crianças: {farofaCrianca:F2} kg";
            lblCerveja.Text = $"CERVEJA: \nHomens: {cervejaHomem:F2} litros       Mulheres: {cervejaMulher:F2} litros       Crianças: {cervejaCrianca:F2} litros";
            lblRefri.Text = $"REFRI: \nHomens: {refriHomem:F2} litros       Mulheres: {refriMulher:F2} litros       Crianças: {refriCrianca:F2} litros";
            lblGelo.Text = $"GELO: \nHomens: {geloHomem:F2} kg       Mulheres: {geloMulher:F2} kg       Crianças: {geloCrianca:F2} kg";
            lblCarvao.Text = $"Total de carne: {totalCarne:F2} kg\nSacos de carvão necessários: {carvaoSacos} \nTotal de kg de carvao: {carvaoKg}";
        

    }
    }
}