namespace apiLeviathansChilds.domain.resources
{
    public static class Messages
    {
        public static string X0_IS_OBRIGATORY(string param) => $"{param} is obrigatory";
        public static string INFORM_A_VALID_X0(string param) => $"Inform a valid {param}";
        public static string INFORM_A_PASSWORD_WITH_X0_TO_X1_CHARACTERS(string value1, string value2) => $"The password need to have between {value1} to {value2} characters";
    }
}