using System;
class chef
{
    public void mc()
    {
        Console.Write("The chef makes chicken.");

    }
    public void ms()
    {
        Console.WriteLine("The chef makes salad.");

    }
    public virtual void msd()
    {
        Console.WriteLine("The chef makes special dish.");

    }



}
class itchef :chef
{

}
class program
{
    static void Main(string[] args)
    {

        var chef1 = new chef();
        chef1.ms();
        var chef2 = new itchef();
        chef2.msd();

    }




}