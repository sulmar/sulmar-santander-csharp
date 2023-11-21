

// Obiekt - instancja klasy

// Inicjalizacja obiektu z pomocą pól

// Inicjalizacja obiektu za pomocą inicjalizatorów



// 




class Transfer
{
    public string Title;
    public DateTime Date;
    public decimal Amount;

    public Account From;
    public Account To;

    public Transfer()
    {
        Date = DateTime.Now;
    }

    // Methoda (Method)
    public void MakeTransfer()
    {
        this.From.Balance -= this.Amount;
        this.To.Balance += this.Amount;
    }
}





