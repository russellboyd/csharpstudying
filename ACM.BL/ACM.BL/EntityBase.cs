using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        protected bool IsNew { get; private set; }
        public bool IsValid
        {
            get
            {
                return true;
            }
        }

        public bool Validate()
        {

        }
    }
}
