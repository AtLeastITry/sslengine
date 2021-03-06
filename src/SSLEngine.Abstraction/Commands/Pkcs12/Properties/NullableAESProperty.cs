﻿using SSLEngine.Abstraction.Commands.Pkcs12.Types;

namespace SSLEngine.Abstraction.Commands.Pkcs12.Properties
{
    internal class NullableAESProperty : CommandProperty<AES?>
    {
        public NullableAESProperty(AES? value, string alias) : base(value, alias)
        {
        }

        public override string ToString()
        {
            if (!Value.HasValue)
                return "";

            return $" {Alias} {Value}";
        }
    }
}
