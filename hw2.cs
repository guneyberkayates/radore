  
    public interface IUcabilir
    {
        void Uc();
    }

    public interface IYuzebilir
    {
        void Yuz();
    }

    public interface IHizliGidebilir
    {
        void HizliGit();
    }

    public class BMW : IUcabilir, IYuzebilir, IHizliGidebilir
    {
        public void Uc()
        {
            Console.WriteLine("BMW havada uçuyor");
        }

        public void Yuz()
        {
            Console.WriteLine("BMW denizde yüzüyor");
        }

        public void HizliGit()
        {
            Console.WriteLine("BMW çok hızlı gidiyor");
        }
    }

    public class Mercedes : IUcabilir, IYuzebilir
    {
        public void Uc()
        {
            Console.WriteLine("Mercedes havada uçuyor");
        }

        public void Yuz()
        {
            Console.WriteLine("Mercedes denizde yüzüyor");
        }
    }

    public class Porsche : IHizliGidebilir
    {
        public void HizliGit()
        {
            Console.WriteLine("Porsche çok hızlı gidiyor");
        }
    }
