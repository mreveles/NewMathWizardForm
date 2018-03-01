using System.ComponentModel.DataAnnotations;

namespace NewMathWizardForm.Models {

    public class UserResponse {

        [Required(ErrorMessage = "Please enter a valid number")]
        public float Left { get; set; }

        [Required(ErrorMessage = "Please enter a valid number")]
        public float Right { get; set; }

        [Required(ErrorMessage = "Please specify your function")]
        public string Function { get; set; }
         
        public float Result {get; set;}
    }
}