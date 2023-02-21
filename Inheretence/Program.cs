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
        Console.WriteLine("The chef makes special dish like bbq.");

    }



}
class itchef : chef
{
    public virtual void mp()
    {
        Console.WriteLine("The chef makes pasta.");

    }
    public override void msd()
    {
        Console.WriteLine("The chef makes special dish lide chicken parm.");

    }
}
class program
{
    static void Main(string[] args)
    {

        var chef1 = new chef();
        chef1.ms();
        var chef2 = new itchef();
        chef2.msd();

        chef2.mp();
    }




}