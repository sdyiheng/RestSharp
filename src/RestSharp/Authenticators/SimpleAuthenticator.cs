﻿#region License

//   Copyright © 2009-2020 John Sheehan, Andrew Young, Alexey Zimarev and RestSharp community
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

namespace RestSharp.Authenticators
{
    public class SimpleAuthenticator : IAuthenticator
    {
        readonly string password;

        readonly string passwordKey;

        readonly string username;
        readonly string usernameKey;

        public SimpleAuthenticator(string usernameKey, string username, string passwordKey, string password)
        {
            this.usernameKey = usernameKey;
            this.username    = username;
            this.passwordKey = passwordKey;
            this.password    = password;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddParameter(usernameKey, username);
            request.AddParameter(passwordKey, password);
        }
    }
}