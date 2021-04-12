class Platform 
{
    public Person passenger;
    public Platform next;

    public Platform(Person p)
    {
        passenger = p;
    }

    public override string ToString()
    {
        return "" + passenger.Name;
    }
}
