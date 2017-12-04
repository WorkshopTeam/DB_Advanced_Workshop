namespace TeamBuilderSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime EndDate
        {
            get
            {
                return this.EndDate;
            }
            set
            {
                if (this.StartDate < this.EndDate)
                {
                    throw new ArgumentException("EndDate must be after than StartDate!");
                }
                this.StartDate = value;
            }
        }

        public int CreatorId { get; set; }
        public User Creator { get; set; }
    }
}
