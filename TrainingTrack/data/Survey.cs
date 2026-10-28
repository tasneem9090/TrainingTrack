using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingTrack.data
{
    [Table("Surveys")]
    public class Survey
    {
        public int Id { get; set; }

        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }

        public int TrainingId { get; set; }
        public Training Training { get; set; }



        //public string Notes { get; set; }

        public DateTime SurveyDate { get; set; }
    }
}
