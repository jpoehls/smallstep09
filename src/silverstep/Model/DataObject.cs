using System;

namespace SmallStep09.Model
{
    public abstract class DataObject
    {
        /// <summary>
        /// Record Id in the database.
        /// </summary>
        public int Id { get; set; }
    }
}