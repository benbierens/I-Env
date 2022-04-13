namespace IEnv
{
    public interface IEnv
    {
        string GetEnvVarOrDefault(string env, string defaultValue);
        string GetEnvVar(string env);
    }

    public class Env : IEnv
    {
        public string GetEnvVarOrDefault(string env, string defaultValue)
        {
            var value = Environment.GetEnvironmentVariable(env);
            if (value == null) return defaultValue;
            return value;
        }

        public string GetEnvVar(string env)
        {
            var value = Environment.GetEnvironmentVariable(env);
            if (value == null) throw new ArgumentException($"Expected environment variable '{env}' but was not found.");
            return value;
        }
    }
}
