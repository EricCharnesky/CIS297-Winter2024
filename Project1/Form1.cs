namespace Project1
{

    // redone version of https://github.com/EricCharnesky/CIS297-Winter2024/blob/main/Project0/Program.cs
    public partial class Form1 : Form
    {
        int grossIncome = 0;
        int totalDeductions = 0;
        int adjustedGrossIncome = 0;

        const int STANDARD_MARRIED_DEDUCTIONS = 27_700;
        const int END_OF_10_PERCENT_BRACKET_MARRIED_2023 = 22_000;
        const int END_OF_12_PERCENT_BRACKET_MARRIED_2023 = 89_450;
        const int END_OF_22_PERCENT_BRACKET_MARRIED_2023 = 190_750;
        const int END_OF_24_PERCENT_BRACKET_MARRIED_2023 = 364_200;
        const int END_OF_32_PERCENT_BRACKET_MARRIED_2023 = 462_500;
        const int END_OF_35_PERCENT_BRACKET_MARRIED_2023 = 693_750;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grossIncome += int.Parse(incomeTextBox.Text);
            updateTaxesOwedLabel();
            incomeTextBox.Text = string.Empty;
        }




        void updateTaxesOwedLabel()
        {
            //int deductionsClaimed = 0;
            //if (totalDeductions < STANDARD_MARRIED_DEDUCTIONS)
            //{
            //    deductionsClaimed = STANDARD_MARRIED_DEDUCTIONS;
            //}
            //else
            //{
            //    deductionsClaimed = totalDeductions;
            //}

            int deductionsClaimed = (totalDeductions < STANDARD_MARRIED_DEDUCTIONS)
                ? STANDARD_MARRIED_DEDUCTIONS : totalDeductions;

            adjustedGrossIncome = grossIncome - deductionsClaimed;






            double taxesOwedAt10Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .10, 0, END_OF_10_PERCENT_BRACKET_MARRIED_2023);
            double taxesOwedAt12Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .12, END_OF_10_PERCENT_BRACKET_MARRIED_2023, END_OF_12_PERCENT_BRACKET_MARRIED_2023);
            double taxesOwedAt22Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .22, END_OF_12_PERCENT_BRACKET_MARRIED_2023, END_OF_22_PERCENT_BRACKET_MARRIED_2023);
            double taxesOwedAt24Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .24, END_OF_22_PERCENT_BRACKET_MARRIED_2023, END_OF_24_PERCENT_BRACKET_MARRIED_2023);
            double taxesOwedAt32Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .32, END_OF_24_PERCENT_BRACKET_MARRIED_2023, END_OF_32_PERCENT_BRACKET_MARRIED_2023);
            double taxesOwedAt35Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .35, END_OF_32_PERCENT_BRACKET_MARRIED_2023, END_OF_35_PERCENT_BRACKET_MARRIED_2023);
            double taxesOwedAt37Percent = getTaxesOwedAtBracket(adjustedGrossIncome, .37, END_OF_35_PERCENT_BRACKET_MARRIED_2023, int.MaxValue);


            double totalTaxesOwed = taxesOwedAt10Percent + taxesOwedAt12Percent + taxesOwedAt22Percent
                + taxesOwedAt24Percent + taxesOwedAt32Percent + taxesOwedAt35Percent + taxesOwedAt37Percent;

            // https://stackoverflow.com/questions/1666346/string-format-an-integer-to-use-a-thousands-separator-without-decimal-places-or
            taxesOwedLabel.Text = $"Gross Income: {grossIncome:#,0}{Environment.NewLine}";
            taxesOwedLabel.Text += $"Total Deductions Claimed: {deductionsClaimed:#,0}{Environment.NewLine}";
            taxesOwedLabel.Text += $"Adjusted Gross Income: {adjustedGrossIncome:#,0}{Environment.NewLine}";

            taxesOwedLabel.Text += $"Taxes owed at 10% - ${taxesOwedAt10Percent}{Environment.NewLine}";
            taxesOwedLabel.Text += $"Taxes owed at 12% - ${taxesOwedAt12Percent}{Environment.NewLine}";
            taxesOwedLabel.Text += $"Taxes owed at 22% - ${taxesOwedAt22Percent}{Environment.NewLine}";
            taxesOwedLabel.Text += $"Taxes owed at 24% - ${taxesOwedAt24Percent}{Environment.NewLine}";
            taxesOwedLabel.Text += $"Taxes owed at 32% - ${taxesOwedAt32Percent}{Environment.NewLine}";
            taxesOwedLabel.Text += $"Taxes owed at 35% - ${taxesOwedAt35Percent}{Environment.NewLine}";
            taxesOwedLabel.Text += $"Taxes owed at 37% - ${taxesOwedAt37Percent}{Environment.NewLine}";

            taxesOwedLabel.Text += $"Total taxes owed: ${totalTaxesOwed}{Environment.NewLine}";

            // https://stackoverflow.com/questions/37113595/c-sharp-6-how-to-format-double-using-interpolated-string
            taxesOwedLabel.Text += $"Total taxes owed as % of gross income: {totalTaxesOwed / grossIncome * 100:0.#}%{Environment.NewLine}";
            taxesOwedLabel.Text += $"Total taxes owed as % of adjusted gross income: {totalTaxesOwed / adjustedGrossIncome * 100:0.#}%{Environment.NewLine}";
        }

        double getTaxesOwedAtBracket(int adjustedGrossIncome, double bracketRate, int bracketStart, int bracketEnd)
        {
            if (adjustedGrossIncome > bracketEnd)
            {
                return (bracketEnd - bracketStart) * bracketRate;
            }
            else if (adjustedGrossIncome < bracketStart)
            {
                return 0;
            }
            return (adjustedGrossIncome - bracketStart) * bracketRate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalDeductions += int.Parse(deductionTextBox.Text);
            updateTaxesOwedLabel();
            deductionTextBox.Text = string.Empty;
        }
    }
}