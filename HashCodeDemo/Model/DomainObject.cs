using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HashCodeDemo.Model
{
    internal class DomainObject
    {
        //public Guid Id { get; set; }
        public string CityCode { get; set; }
        public int LotId { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int CurrentBatteryLevel { get; set; }

        public DomainObject() { }
        public DomainObject(string cityCode, int lotId, string name, string description, string type, int currentBatteryLevel) 
        { 
            this.CityCode = cityCode;
            this.LotId = lotId;
            this.Name = name;
            this.Description = description; 
            this.Type = type;   
            this.CurrentBatteryLevel = currentBatteryLevel;            
        }

        public override bool Equals(object? obj)
        {
            return obj is DomainObject @object &&
                   CityCode == @object.CityCode &&
                   LotId == @object.LotId &&
                   Name == @object.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CityCode, LotId, Name);
        }


        //public override bool Equals(object? obj)
        //{
        //    DomainObject obj2 = obj as DomainObject;
        //    if (obj2 == null) return false;
        //    if (!this.Id.Equals(obj2.Id)) return false;
        //    return true;
        //}

        //public override int GetHashCode()
        //{
        //    unchecked
        //    {
        //        int hash = 17;
        //        hash = hash * 23 + Id.GetHashCode();
        //        return hash;
        //    }            
        //}
    }
}
