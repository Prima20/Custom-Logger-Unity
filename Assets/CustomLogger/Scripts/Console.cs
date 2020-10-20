using UnityEngine;

namespace raion.CustomLogger
{
    public class Console
    {
        public static int FontSize = 15;

        #region Colors
        private static string GREEN = "#008000ff";
        private static string YELLOW = "#ffff00ff";
        private static string RED = "#ff0000ff";
        #endregion

        public Console() { }

        #region Info
        public static void Info(object message)
        {
            Log(style($"<color={GREEN}>{message}</color>"));
        }

        public static void Info(object message, Object context)
        {
            Log(style($"<color={GREEN}>{message}</color>"), context);
        }

        public static void Info(object obj, object message)
        {
            var name = obj.GetType().Name;
            Log(style($"<color={GREEN}>[<b>{name}</b>] : {message}</color>"));
        }
        #endregion

        #region Warn
        public static void Warn(object message)
        {
            LogWarning(style($"<color={YELLOW}>{message}</color>"));
        }

        public static void Warn(object message, Object context)
        {
            LogWarning(style($"<color={YELLOW}>{message}</color>"), context);
        }

        public static void Warn(object obj, object message)
        {
            var name = obj.GetType().Name;
            LogWarning(style($"<color={YELLOW}>[<b>{name}</b>] : {message}</color>"));
        }
        #endregion

        #region Error
        public static void Error(object message)
        {
            LogError(style($"<color={RED}>{message}</color>"));
        }

        public static void Error(object message, Object context)
        {
            LogError(style($"<color={RED}>{message}</color>"), context);
        }

        public static void Error(object obj, object message)
        {
            var name = obj.GetType().Name;
            LogError(style($"<color={RED}>[<b>{name}</b>] : {message}</color>"));
        }
        #endregion

        #region Base Log
        private static void Log(object message)
        {
            Debug.Log(message);
        }
        private static void Log(object message, Object context)
        {
            Debug.Log(message, context);
        }
        private static void LogWarning(object message)
        {
            Debug.LogWarning(message);
        }

        private static void LogWarning(object message, Object context)
        {
            Debug.LogWarning(message, context);
        }

        private static void LogError(object message)
        {
            Debug.LogError(message);
        }

        private static void LogError(object message, Object context)
        {
            Debug.LogError(message, context);
        }
        #endregion

        #region Style

        private static object style(object message)
        {
            return "<size=" + FontSize.ToString() + ">" + message + "</size>\n";
        }
        #endregion
    }
}

