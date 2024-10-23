using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class Account
    {
        [Key]
        public int IdAcc { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; } 
        public string Role { get; set; }
        public string Status { get; set; }
        public int? IdPosition { get; set; }
        public int? IdArea { get; set; }
        public int? IdDis { get; set; }
        public int? IdManager { get; set; }
        public Position? Position { get; set; }
        public Area? Area { get; set; }
        public Distributor? Distributor { get; set; }
        public Account? AccManager { get; set; }
        public ICollection<Account>? managedAccounts { get; set; }
        public ICollection<AccountAnswer>? accountAnswers { get; set; }
        public ICollection<AccountNotification>? accountNotifications { get; set; }
        public ICollection<AccountSurveyRequest>? accountSurveyRequests { get; set; }
        public ICollection<Article>? articles { get; set; }
        public ICollection<ArticleImage>? articleImages { get; set; }
        public ICollection<Distributor>? ManagedDistributors { get; set; }
        public ICollection<Job>? jobImplementers { get; set; }
        public ICollection<Job>? jobCreators { get; set; }
        public ICollection<Notification>? notifications { get; set; }
        public ICollection<SurveyArticle>? surveyArticles { get; set; }
        public ICollection<SurveyRequest>? surveyRequests { get; set; }
        public ICollection<Visitor>? visitors { get; set; }
        public ICollection<VisitSchedule>? visitSchedules { get; set; }
    }
}
