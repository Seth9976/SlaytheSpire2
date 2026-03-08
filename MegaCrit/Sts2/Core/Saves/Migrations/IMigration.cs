namespace MegaCrit.Sts2.Core.Saves.Migrations;

public interface IMigration<T> : IMigration where T : ISaveSchema
{
}
