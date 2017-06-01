using Bridge;

namespace System
{
    [External]
    [Convention(Target = ConventionTarget.Member, Member = ConventionMember.Method, Notation = Notation.LowerCamelCase)]
    [Reflectable]
    public interface IFormatProvider : IBridgeClass
    {
        object GetFormat(Type formatType);
    }
}