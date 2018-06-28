using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Wisej.ASPNETMVCAuthentication {
    public class AuthSessionStore : IAuthenticationSessionStore {
        ConcurrentDictionary<string, AuthenticationTicket> keys = new ConcurrentDictionary<string, AuthenticationTicket>();
        public Task RemoveAsync(string key) {
            return Task.Run(() =>
            {
                AuthenticationTicket ticket;
                keys.TryRemove(key, out ticket);
            });
        }

        public Task RenewAsync(string key, AuthenticationTicket ticket) {
            return Task.Run(() =>
            {
                keys[key] = ticket;
            });
        }

        public Task<AuthenticationTicket> RetrieveAsync(string key) {
            AuthenticationTicket ticket;
            keys.TryGetValue(key, out ticket);
            return Task.FromResult(ticket);
        }

        public Task<string> StoreAsync(AuthenticationTicket ticket) {
            string key = Guid.NewGuid().ToString();
            keys.TryAdd(key, ticket);
            return Task.FromResult(key);
        }
    }
}