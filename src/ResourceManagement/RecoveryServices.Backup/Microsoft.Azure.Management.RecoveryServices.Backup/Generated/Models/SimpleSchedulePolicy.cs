// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Simple policy schedule.
    /// </summary>
    public partial class SimpleSchedulePolicy : SchedulePolicy
    {
        /// <summary>
        /// Initializes a new instance of the SimpleSchedulePolicy class.
        /// </summary>
        public SimpleSchedulePolicy() { }

        /// <summary>
        /// Initializes a new instance of the SimpleSchedulePolicy class.
        /// </summary>
        /// <param name="scheduleRunFrequency">Frequency of the schedule
        /// operation of this policy. Possible values include: 'Invalid',
        /// 'Daily', 'Weekly'</param>
        /// <param name="scheduleRunDays">List of days of week this schedule
        /// has to be run.</param>
        /// <param name="scheduleRunTimes">List of times of day this schedule
        /// has to be run.</param>
        /// <param name="scheduleWeeklyFrequency">At every number weeks this
        /// schedule has to be run.</param>
        public SimpleSchedulePolicy(ScheduleRunType? scheduleRunFrequency = default(ScheduleRunType?), System.Collections.Generic.IList<DayOfWeek?> scheduleRunDays = default(System.Collections.Generic.IList<DayOfWeek?>), System.Collections.Generic.IList<System.DateTime?> scheduleRunTimes = default(System.Collections.Generic.IList<System.DateTime?>), int? scheduleWeeklyFrequency = default(int?))
        {
            ScheduleRunFrequency = scheduleRunFrequency;
            ScheduleRunDays = scheduleRunDays;
            ScheduleRunTimes = scheduleRunTimes;
            ScheduleWeeklyFrequency = scheduleWeeklyFrequency;
        }

        /// <summary>
        /// Gets or sets frequency of the schedule operation of this policy.
        /// Possible values include: 'Invalid', 'Daily', 'Weekly'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleRunFrequency")]
        public ScheduleRunType? ScheduleRunFrequency { get; set; }

        /// <summary>
        /// Gets or sets list of days of week this schedule has to be run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleRunDays")]
        public System.Collections.Generic.IList<DayOfWeek?> ScheduleRunDays { get; set; }

        /// <summary>
        /// Gets or sets list of times of day this schedule has to be run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleRunTimes")]
        public System.Collections.Generic.IList<System.DateTime?> ScheduleRunTimes { get; set; }

        /// <summary>
        /// Gets or sets at every number weeks this schedule has to be run.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scheduleWeeklyFrequency")]
        public int? ScheduleWeeklyFrequency { get; set; }

    }
}
