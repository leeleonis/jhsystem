using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace jhsystem.Models
{
    
    /// <summary>
    /// Service class
    /// </summary>
    [MetadataType(typeof(ServiceMetadata))]
    public  partial class Service
    {
    
    	/// <summary>
    	/// Service Metadata class
    	/// </summary>
    	public   class ServiceMetadata
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
    
    		    
    		/// <summary>
    		/// Create By
    		/// </summary>        
    	    [Display(Name = "CreateBy", ResourceType = typeof(App_GlobalResources.Resource))]
            [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(App_GlobalResources.Resource))]
            [MaxLength(50, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(App_GlobalResources.Resource))]
    		public string  CreateBy { get; set; }
    
    		    
    		/// <summary>
    		/// Create At
    		/// </summary>        
    	    [Display(Name = "CreateAt", ResourceType = typeof(App_GlobalResources.Resource))]
            [UIHint("DateTime")]
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(App_GlobalResources.Resource))]
    		public System.DateTime  CreateAt { get; set; }
    
    		    
    		/// <summary>
    		/// Update By
    		/// </summary>        
    	    [Display(Name = "UpdateBy", ResourceType = typeof(App_GlobalResources.Resource))]
            [MaxLength(50, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(App_GlobalResources.Resource))]
    		public string  UpdateBy { get; set; }
    
    		    
    		/// <summary>
    		/// Update At
    		/// </summary>        
    	    [Display(Name = "UpdateAt", ResourceType = typeof(App_GlobalResources.Resource))]
            [UIHint("DateTime")]
    		public Nullable<System.DateTime>  UpdateAt { get; set; }
    
    		    
    		/// <summary>
    		/// Memo
    		/// </summary>        
    	    [Display(Name = "Memo", ResourceType = typeof(App_GlobalResources.Resource))]
    		public string  Memo { get; set; }
    
    		    
    	}
    }
    
}
