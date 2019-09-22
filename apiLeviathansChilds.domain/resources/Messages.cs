namespace apiLeviathansChilds.domain.resources
{
    public static class Messages
    {
        public static string X0_IS_OBRIGATORY(string param) => $"{param} is obrigatory";

        public static string INFORM_A_VALID_X0(string param) => $"Inform a valid {param}";

        public static string X0_NEED_TO_HAVE_BETWEEN_X1_TO_X2_CHARACTERS(string param, string value1, string value2) =>
            $"{param} need to have between {value1} to {value2} characters";

        public static string INFORM_A_PASSWORD_WITH_X0_TO_X1_CHARACTERS(string value1, string value2) =>
            $"The password need to have between {value1} to {value2} characters";

        public static string X0_SUCCESSFULLY_CREATED(string param) => $"{param} successfully created";
        public static string X0_SUCCESSFULLY_UPDATED(string param) => $"{param} successfully updated";
        public static string X0_SUCCESSFULLY_REMOVED(string param) => $"{param} successfully removed";

        public static string X0_NOT_FOUND(string param) => $"{param} not found";

        public static string X0_INVALID(string param) => $"{param} invalid";

        public static string X0_FAILED(string param) => $"{param} failed";
    }
}