using System;
using System.ComponentModel;
using System.Reflection;

namespace Member.Common.Helpers
{
    /// <summary>
    /// EnumHelper classe de auxilio para enumeradores 
    /// </summary>
    public static class EnumHelper
    {
        #region Métodos

        /// <summary>
        /// GetDescription obtém a descrição para enumeradores
        /// </summary>
        /// <param name="value">valor do enumerados</param>
        /// <returns>String com a descrição referente ao valor</returns>
        public static string GetDescription(object value)
        {
            var type = value.GetType();
            var name = System.Enum.GetName(type, value);
            if (name == null) return string.Empty;
            var field = type.GetField(name);
            if (field != null)
            {
                var attr = GetDescriptionAttribute(field);
                if (attr != null) return attr.Description;
            }
            return name.Replace("_", " ");
        }

        /// <summary>
        /// GetDescriptionAttribute obtém os atributos de descrição 
        /// </summary>
        /// <param name="field">valor variável do field tipo MemberInfo</param>
        /// <returns>Retorna objeto DescriptionAttibute </returns>
        private static DescriptionAttribute GetDescriptionAttribute(MemberInfo field)
        {
            return
                Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute ?? null ;
        }

        /// <summary>
        /// GetDescription obtém a descrição do enumerador 
        /// </summary>
        /// <param name="enumType">tipo do enumerador</param>
        /// <param name="value">valor do enumerador</param>
        /// <returns>Descrição do enumerador</returns>
        public static string GetDescription(Type enumType, string value)
        {
            return GetDescription(System.Enum.Parse(enumType, value));
        }

        /// <summary>
        /// ParseEnum converte o o valor via parse para o enumerador 
        /// </summary>
        /// <param name="value">valor a ser passado como string</param>
        /// <returns>Enumerador </returns>
        public static T ParseEnum<T>(string value)
        {
            return (T)System.Enum.Parse(typeof(T), value, true);
        }

        #endregion 
    }
}
