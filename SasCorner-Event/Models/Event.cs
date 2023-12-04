using System;
namespace SasCorner_Event.Models
{
	public class Event
	{
		public Event()
		{
        }
        #region Public members
        /// <summary>
        /// Id:Calendar id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title:Başlık
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// StartDate:Başlangıc
        /// </summary>
        public string StartDate { get; set; }
        #endregion
    
}
}

