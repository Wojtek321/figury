namespace program
{
    public class Punkt
    {
        private int x;
        private int y;

        public Punkt()
        {
            this.x = 0;
            this.y = 0;
        }
    
        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    
        public Punkt(Punkt punkt)
        {
            this.x = punkt.x;
            this.y = punkt.y;
        }

        public void przesun(int x, int y)
        {
            this.x += x;
            this.y += y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    public class Linia
    {
        private Punkt p1;
        private Punkt p2;

        public Linia()
        {
            this.p1 = new Punkt();
            this.p2 = new Punkt();
        }
        
        public Linia(Punkt p1, Punkt p2)
        {
            this.p1 = new Punkt(p1);
            this.p2 = new Punkt(p2);
        }
        
        public Linia(Linia linia)
        {
            this.p1 = new Punkt(linia.p1);
            this.p2 = new Punkt(linia.p2);
        }

        public void przesun(int x, int y)
        {
            this.p1.przesun(x, y);
            this.p2.przesun(x, y);
        }

        public override string ToString()
        {
            return $"[{p1}, {p2}]";
        }
    }

    class Trojkat
    {
        private Linia l1;
        private Linia l2;
        private Linia l3;

        public Trojkat()
        {
            this.l1 = new Linia();
            this.l2 = new Linia();
            this.l3 = new Linia();
        }
        
        public Trojkat(Punkt p1, Punkt p2, Punkt p3)
        {
            this.l1 = new Linia(p1, p2);
            this.l2 = new Linia(p2, p3);
            this.l3 = new Linia(p3, p1);
        }

        public Trojkat(Trojkat trojkat)
        {
            this.l1 = new Linia(trojkat.l1);
            this.l2 = new Linia(trojkat.l2);
            this.l3 = new Linia(trojkat.l3);
        }

        public void przesun(int x, int y)
        {
            this.l1.przesun(x, y);
            this.l2.przesun(x, y);
            this.l3.przesun(x, y);
        }

        public override string ToString()
        {
            return "Trojkat: {" + l1 + ", " + l2 + ", " + l3 + "}";
        }
    }

    class Czworokat
    {
        private Linia l1;
        private Linia l2;
        private Linia l3;
        private Linia l4;

        public Czworokat()
        {
            this.l1 = new Linia();
            this.l2 = new Linia();
            this.l3 = new Linia();
            this.l4 = new Linia();
        }
        
        public Czworokat(Punkt p1, Punkt p2, Punkt p3, Punkt p4)
        {
            this.l1 = new Linia(p1, p2);
            this.l2 = new Linia(p2, p3);
            this.l3 = new Linia(p3, p4);
            this.l4 = new Linia(p4, p1);
        }

        public Czworokat(Czworokat czworokat)
        {
            this.l1 = new Linia(czworokat.l1);
            this.l1 = new Linia(czworokat.l2);
            this.l1 = new Linia(czworokat.l3);
            this.l1 = new Linia(czworokat.l4);
        }

        public void przesun(int x, int y)
        {
            this.l1.przesun(x, y);
            this.l2.przesun(x, y);
            this.l3.przesun(x, y);
            this.l4.przesun(x, y);
        }

        public override string ToString()
        {
            return "Czworokat: {" + l1 + ", " + l2 + ", " + l3 + ", " + l4 + "}";
        }
    }

    class Obraz
    {
        private List<Trojkat> trojkaty = new List<Trojkat>();
        private List<Czworokat> czworokaty = new List<Czworokat>();

        public Obraz()
        {
            trojkaty.Clear();
            czworokaty.Clear();
        }

        public void dodajTrojkat(Trojkat trojkat)
        {
            trojkaty.Add(trojkat);
        }

        public void dodajCzworokat(Czworokat czworokat)
        {
            czworokaty.Add(czworokat);
        }

        public void przesun(int x, int y)
        {
            foreach (Trojkat trojkat in trojkaty)
            {
                trojkat.przesun(x, y);
            }

            foreach (Czworokat czworokat in czworokaty)
            {
                czworokat.przesun(x, y);
            }
        }

        public override string ToString()
        {
            string response = "";
            
            foreach (Trojkat trojkat in trojkaty)
            {
                response += trojkat + "\n";
            }
            
            foreach (Czworokat czworokat in czworokaty)
            {
                response += czworokat + "\n";
            }

            return response;
        }
    }
}
