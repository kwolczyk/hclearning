namespace Hc.Learning.Introduction
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var presenter = new ArgumentPresenter();
            presenter.Show(args);
        }
    }
}