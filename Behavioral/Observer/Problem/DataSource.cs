namespace Observer.Problem
{
    /// <summary>
    /// Whenever this Value property of the DataSource object is changed, other objects need to be "notified"
    /// </summary>
    public class DataSource
    {
        /// <summary>
        /// Here is the problem. In our DataSource class, whenever we set the value of this particualar field,
        /// we need to notify the objects from Chart & SpreadSheet classes. But at the time of writing this code,
        /// we do not know how many instances of SpreadSheet or Chart class objects are dependent on the
        /// below value. That may change later at runtime. The user may add new spreadsheets or new charts
        /// that are dependent on the value of the DataSource class.
        /// </summary>
        public int Value { get; set; }
    }
}
