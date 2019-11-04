using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace jhsystem.Models
{
    
    /// <summary>
    /// Img class
    /// </summary>
    [MetadataType(typeof(ImgMetadata))]
    public  partial class Img
    {
    
    	/// <summary>
    	/// Img Metadata class
    	/// </summary>
    	public   class ImgMetadata
    	{
    		    
    		/// <summary>
    		/// Is Enable
    		/// </summary>        
    	    [Display(Name = "IsEnable", ResourceType = typeof(App_GlobalResources.Resource))]
            [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(App_GlobalResources.Resource))]
    		public bool  IsEnable { get; set; }
    
    		    
    		/// <summary>
    		/// ID
    		/// </summary>        
    	    [Display(Name = "ID", ResourceType = typeof(App_GlobalResources.Resource))]
            [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(App_GlobalResources.Resource))]
    		public int  ID { get; set; }
    
    		    
    		/// <summary>
    		/// Title
    		/// </summary>        
    	    [Display(Name = "Title", ResourceType = typeof(App_GlobalResources.Resource))]
            [MaxLength(50, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(App_GlobalResources.Resource))]
    		public string  Title { get; set; }
    
    		    
    		/// <summary>
    		/// Body
    		/// </summary>        
    	    [Display(Name = "Body", ResourceType = typeof(App_GlobalResources.Resource))]
    		public string  Body { get; set; }
    
    		    
    		/// <summary>
    		/// SEO
    		/// </summary>        
    	    [Display(Name = "SEO", ResourceType = typeof(App_GlobalResources.Resource))]
    		public string  SEO { get; set; }
    
    		    
    		/// <summary>
    		/// Sort
    		/// </summary>        
    	    [Display(Name = "Sort", ResourceType = typeof(App_GlobalResources.Resource))]
    		public Nullable<int>  Sort { get; set; }
    
    		    
    		/// <summary>
    		/// Show Time
    		/// </summary>        
    	    [Display(Name = "ShowTime", ResourceType = typeof(App_GlobalResources.Resource))]
            [UIHint("DateTime")]
    		public Nullable<System.DateTime>  ShowTime { get; set; }
    
    		    
    		/// <summary>
    		/// Url
    		/// </summary>        
    	    [Display(Name = "Url", ResourceType = typeof(App_GlobalResources.Resource))]
    		public string  Url { get; set; }
    
    		    
    	}
    }
    
}
