﻿using OpenSSLEngine.Abstraction;
using OpenSSLEngine.Abstraction.Commands.Pkcs12;

namespace OpenSSLEngine.Domain
{
    public class Pkcs12Command : OpenSSLCommand<Pkcs12Options, Pkcs12Input>
    {
        public Pkcs12Command(IOpenSSLResourceHandler openSSLResourceHandler) : base(openSSLResourceHandler)
        {
        }
    }
}