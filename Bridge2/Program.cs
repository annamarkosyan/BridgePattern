using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class View
    {
        public IResource _resource;
        public View(IResource resource)
        {
            _resource = resource;
        }
        public abstract string Show();
    }

    internal class LongForm : View
    {
        public LongForm(IResource resource) : base(resource)
        {
        }

        public override string Show()
        {
            this._resource.Snippet();
            return "";
        }

    }

    public interface IResource
    {
        string Snippet();
        string Title();
        string Image();
        string Url();
    }

    public class ArtirstResource : IResource
    {
        public Artist artist;
        public ArtirstResource(Artist a)
        {
            this.artist = a;
        }
        public string Image()
        {
            throw new NotImplementedException();
        }

        public string Snippet()
        {
            return this.artist.Bio();
        }

        public string Title()
        {
            return this.artist.Name() + " " + this.artist.LastName();
        }

        public string Url()
        {
            throw new NotImplementedException();
        }
    }

    public class Artist
    {
        internal string Bio()
        {
            throw new NotImplementedException();
        }

        internal string LastName()
        {
            throw new NotImplementedException();
        }

        internal string Name()
        {
            throw new NotImplementedException();
        }
    }


    //public abstract class Vehicle
    //{
    //    private Make make;
    //    public void Start()
    //    {
    //        make.PerformRitual();
    //        make.StartCar();
    //    }

    //    public abstract bool AllowedToDrive(string person);
    //}

    //public abstract class Make
    //{
    //    public abstract void PerformRitual();

    //    public abstract void StartCar();
    //}
    //public class Car : Vehicle
    //{
    //    public override bool AllowedToDrive(string person) => person == "has license";
    //}
    //public class Truck : Vehicle
    //{
    //    public override bool AllowedToDrive(string person) => person == "has special truck license";
    //}

    //public class Lada : Make
    //{
    //    public override void PerformRitual() => Console.WriteLine("Hit the car");

    //    public override void StartCar()
    //    {
    //        Console.WriteLine("fix the wiring");
    //        Console.WriteLine("lube the engine");
    //        Console.WriteLine("put the key in");
    //        Console.WriteLine("turn the key");
    //    }
    //}
    //public class Volvo : Make
    //{
    //    public override void PerformRitual() => Console.WriteLine("Greatful for buying Volvo");

    //    public override void StartCar() => Console.WriteLine("Press the button");
    //}

}
