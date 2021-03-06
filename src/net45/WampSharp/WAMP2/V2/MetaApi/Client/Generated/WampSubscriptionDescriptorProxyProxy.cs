using System.Reflection;
using System.Threading.Tasks;
using WampSharp.V2.CalleeProxy;
using WampSharp.V2.Client;

namespace WampSharp.V2.MetaApi
{
    //------------------------------------------------------------------------------
    // <auto-generated>
    //     This code was generated by a tool.
    //
    //     Changes to this file may cause incorrect behavior and will be lost if
    //     the code is regenerated.
    // </auto-generated>
    //------------------------------------------------------------------------------
    internal class WampSubscriptionDescriptorProxyProxy : CalleeProxyBase, global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy
    {
        private static readonly MethodInfo mMethod0 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.GetAllSubscriptionIds());
        private static readonly MethodInfo mMethod1 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.LookupSubscriptionId(default(string), default(global::WampSharp.V2.Core.Contracts.SubscribeOptions)));
        private static readonly MethodInfo mMethod2 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.GetMatchingSubscriptionIds(default(string)));
        private static readonly MethodInfo mMethod3 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.GetSubscriptionDetails(default(long)));
        private static readonly MethodInfo mMethod4 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.GetSubscribers(default(long)));
        private static readonly MethodInfo mMethod5 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.CountSubscribers(default(long)));
        private static readonly MethodInfo mMethod6 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.GetAllSubscriptionIdsAsync());
        private static readonly MethodInfo mMethod7 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.LookupSubscriptionIdAsync(default(string), default(global::WampSharp.V2.Core.Contracts.SubscribeOptions)));
        private static readonly MethodInfo mMethod8 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.GetMatchingSubscriptionIdsAsync(default(string)));
        private static readonly MethodInfo mMethod9 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.GetSubscriptionDetailsAsync(default(long)));
        private static readonly MethodInfo mMethod10 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.GetSubscribersAsync(default(long)));
        private static readonly MethodInfo mMethod11 = GetMethodInfo((global::WampSharp.V2.MetaApi.IWampSubscriptionDescriptorProxy instance) => instance.CountSubscribersAsync(default(long)));

        public WampSubscriptionDescriptorProxyProxy
                (IWampRealmProxy realmProxy,
                 ICalleeProxyInterceptor interceptor)
            : base(realmProxy, interceptor)
        {
        }

        public global::WampSharp.V2.MetaApi.AvailableGroups GetAllSubscriptionIds()
        {
            return SingleInvokeSync<global::WampSharp.V2.MetaApi.AvailableGroups>(mMethod0);
        }

        public global::System.Nullable<long> LookupSubscriptionId(string topicUri, global::WampSharp.V2.Core.Contracts.SubscribeOptions options)
        {
            return SingleInvokeSync<global::System.Nullable<long>>(mMethod1, topicUri, options);
        }

        public long[] GetMatchingSubscriptionIds(string topicUri)
        {
            return SingleInvokeSync<long[]>(mMethod2, topicUri);
        }

        public global::WampSharp.V2.MetaApi.SubscriptionDetails GetSubscriptionDetails(long subscriptionId)
        {
            return SingleInvokeSync<global::WampSharp.V2.MetaApi.SubscriptionDetails>(mMethod3, subscriptionId);
        }

        public long[] GetSubscribers(long subscriptionId)
        {
            return SingleInvokeSync<long[]>(mMethod4, subscriptionId);
        }

        public long CountSubscribers(long subscriptionId)
        {
            return SingleInvokeSync<long>(mMethod5, subscriptionId);
        }

        public Task<global::WampSharp.V2.MetaApi.AvailableGroups> GetAllSubscriptionIdsAsync()
        {
            return SingleInvokeAsync<global::WampSharp.V2.MetaApi.AvailableGroups>(mMethod6);
        }

        public Task<global::System.Nullable<long>> LookupSubscriptionIdAsync(string topicUri, global::WampSharp.V2.Core.Contracts.SubscribeOptions options)
        {
            return SingleInvokeAsync<global::System.Nullable<long>>(mMethod7, topicUri, options);
        }

        public Task<long[]> GetMatchingSubscriptionIdsAsync(string topicUri)
        {
            return SingleInvokeAsync<long[]>(mMethod8, topicUri);
        }

        public Task<global::WampSharp.V2.MetaApi.SubscriptionDetails> GetSubscriptionDetailsAsync(long subscriptionId)
        {
            return SingleInvokeAsync<global::WampSharp.V2.MetaApi.SubscriptionDetails>(mMethod9, subscriptionId);
        }

        public Task<long[]> GetSubscribersAsync(long subscriptionId)
        {
            return SingleInvokeAsync<long[]>(mMethod10, subscriptionId);
        }

        public Task<long> CountSubscribersAsync(long subscriptionId)
        {
            return SingleInvokeAsync<long>(mMethod11, subscriptionId);
        }
    }
}