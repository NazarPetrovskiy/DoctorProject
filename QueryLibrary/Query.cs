namespace QueryLibrary
{

    #region Our enum data

    public enum StatusQuery
    {
        LogIn,
        SignIn,
        ForgotPassword,
        TempPassword,
        Query,
        Null
    }

    public enum TypeCommand
    {
        Add,
        Delete,
        Update,
        GetItem,
        GetAll,
        Null
    }

    public enum CurrentModel
    {
        People,
        Patient,
        Doctor,
        Analys,
        Disease,
        Null
    }
    #endregion

    public class Query
    {

        public StatusQuery Status { get; set; }

        public TypeCommand Type { get; set; }

        public CurrentModel CurrentModel { get; set; }

        public string Content { get; set; }
  

    }


    
}
