namespace InterfacesDemo
{
    interface IPrey : IAnimal
    {
        int Fleespeed { get; set; }

        void Flee();
    }
}