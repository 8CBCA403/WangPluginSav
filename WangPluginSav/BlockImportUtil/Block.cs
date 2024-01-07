using System.Runtime.CompilerServices;
using System.Text;

namespace WangPluginSav;

public record class Block(uint Location, string Path)
{
    public static implicit operator Block(uint l) => new Block(l, string.Empty);
    public static implicit operator uint(Block b) => b.Location;
    [CompilerGenerated]
    protected virtual Type EqualityContract
    {
        [CompilerGenerated]
        get
        {
            return typeof(Block);
        }
    }

    public static implicit operator Block((uint, string) v)
    {
        return new Block(v.Item1, v.Item2);
    }

    [CompilerGenerated]
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Block");
        stringBuilder.Append(" { ");
        if (PrintMembers(stringBuilder))
        {
            stringBuilder.Append(' ');
        }
        stringBuilder.Append('}');
        return stringBuilder.ToString();
    }

    [CompilerGenerated]
    protected virtual bool PrintMembers(StringBuilder builder)
    {
        RuntimeHelpers.EnsureSufficientExecutionStack();
        builder.Append("Location = ");
        builder.Append(Location.ToString());
        builder.Append(", Path = ");
        builder.Append((object?)Path);
        return true;
    }

    [CompilerGenerated]
    public override int GetHashCode()
    {
        return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(Location)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path);
    }

    [CompilerGenerated]
    public virtual bool Equals(Block? other)
    {
        if ((object)this != other)
        {
            if (other is not null && EqualityContract == other!.EqualityContract && EqualityComparer<uint>.Default.Equals(Location, other!.Location))
            {
                return EqualityComparer<string>.Default.Equals(Path, other!.Path);
            }
            return false;
        }
        return true;
    }

    [CompilerGenerated]
    protected Block(Block original)
    {
        Location = original.Location;
        Path = original.Path;
    }
}
