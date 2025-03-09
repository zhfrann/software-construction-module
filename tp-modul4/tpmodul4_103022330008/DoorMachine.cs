class DoorMachine
{
    private enum State { TERKUNCI, TERBUKA };

    private State currentState;

    public DoorMachine()
    {
        this.currentState = State.TERKUNCI;
    }

    public void BukaPintu()
    {
        if (this.currentState == State.TERKUNCI)
        {
            this.currentState = State.TERBUKA;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void KunciPintu()
    {
        if (this.currentState == State.TERBUKA)
        {
            this.currentState = State.TERKUNCI;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
}
