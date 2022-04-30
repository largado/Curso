
    class Hospital
    {
    public string medico;
    public string paciente;
    public string predio;
    public float preco;
    public double pagamento;
    public int notafiscal;


    public bool Opera(double valor)
    {
        if (this.medico is null)
        {
            medico = "Sem Médico";
            return false;
        }
        else
        {
            preco = 132;
            return true;
        }
            

    }
        

    }

