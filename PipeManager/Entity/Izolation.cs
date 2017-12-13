using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeManager.Entity
{
    struct Izolation : IEquatable<Izolation>
    {
        public string Type { get; set; }
        public double Tube { get; set; }
        public double Layer1 { get; set; }
        public double Layer2 { get; set; }
        public double Layer3 { get; set; }

        public Izolation(string type, double tube, double layer1, double layer2, double layer3)
        {
            Type = type;
            Tube = tube;
            Layer1 = layer1;
            Layer2 = layer2;
            Layer3 = layer3;
        }

        public bool Equals(Izolation other)
        {

            //Check whether the compared object is null.
            if (Object.ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data.
            if (Object.ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal.
            return Type.Equals(other.Type) && Tube.Equals(other.Tube) && Layer1.Equals(other.Layer1) &&
                Layer2.Equals(other.Layer2) && Layer3.Equals(other.Layer3);
        }

        // If Equals() returns true for a pair of objects
        // then GetHashCode() must return the same value for these objects.

        public override int GetHashCode()
        {

            //Get hash code for the Name field if it is not null.
            int hashIzolName = Type == null ? 0 : Type.GetHashCode();

            //Get hash code for the Code field.
            int hashTube = Tube.GetHashCode();
            int hashLayer1 = Layer1.GetHashCode();
            int hashLayer2 = Layer2.GetHashCode();
            int hashLayer3 = Layer3.GetHashCode();

            //Calculate the hash code for the product.
            //return hashProductName ^ hashProductCode;
            return hashIzolName ^ hashTube ^ hashLayer1 ^ hashLayer2 ^ hashLayer3;
        }
    }
}
