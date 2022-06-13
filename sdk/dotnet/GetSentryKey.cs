// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Sentry
{
    public static class GetSentryKey
    {
        /// <summary>
        /// ## # sentry.SentryKey Data Source
        /// 
        /// Sentry Key data source.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Sentry = Pulumi.Sentry;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var @default = Output.Create(Sentry.GetSentryKey.InvokeAsync(new Sentry.GetSentryKeyArgs
        ///         {
        ///             Name = "Default",
        ///             Organization = "my-organization",
        ///             Project = "web-app",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSentryKeyResult> InvokeAsync(GetSentryKeyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSentryKeyResult>("sentry:index/getSentryKey:getSentryKey", args ?? new GetSentryKeyArgs(), options.WithDefaults());

        /// <summary>
        /// ## # sentry.SentryKey Data Source
        /// 
        /// Sentry Key data source.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Sentry = Pulumi.Sentry;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var @default = Output.Create(Sentry.GetSentryKey.InvokeAsync(new Sentry.GetSentryKeyArgs
        ///         {
        ///             Name = "Default",
        ///             Organization = "my-organization",
        ///             Project = "web-app",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetSentryKeyResult> Invoke(GetSentryKeyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSentryKeyResult>("sentry:index/getSentryKey:getSentryKey", args ?? new GetSentryKeyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSentryKeyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Boolean flag indicating that we want the first key of the returned keys.
        /// </summary>
        [Input("first")]
        public bool? First { get; set; }

        /// <summary>
        /// The name of the key to retrieve.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The slug of the organization the key should be created for.
        /// </summary>
        [Input("organization", required: true)]
        public string Organization { get; set; } = null!;

        /// <summary>
        /// The slug of the project the key should be created for.
        /// </summary>
        [Input("project", required: true)]
        public string Project { get; set; } = null!;

        public GetSentryKeyArgs()
        {
        }
    }

    public sealed class GetSentryKeyInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Boolean flag indicating that we want the first key of the returned keys.
        /// </summary>
        [Input("first")]
        public Input<bool>? First { get; set; }

        /// <summary>
        /// The name of the key to retrieve.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The slug of the organization the key should be created for.
        /// </summary>
        [Input("organization", required: true)]
        public Input<string> Organization { get; set; } = null!;

        /// <summary>
        /// The slug of the project the key should be created for.
        /// </summary>
        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        public GetSentryKeyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSentryKeyResult
    {
        /// <summary>
        /// DSN for the Content Security Policy (CSP) for the key.
        /// </summary>
        public readonly string DsnCsp;
        /// <summary>
        /// DSN for the key.
        /// </summary>
        public readonly string DsnPublic;
        /// <summary>
        /// DSN (Deprecated) for the key.
        /// </summary>
        public readonly string DsnSecret;
        public readonly bool? First;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Flag indicating the key is active.
        /// </summary>
        public readonly bool IsActive;
        public readonly string? Name;
        public readonly string Organization;
        public readonly string Project;
        /// <summary>
        /// The ID of the project that the key belongs to.
        /// </summary>
        public readonly int ProjectId;
        /// <summary>
        /// Public key portion of the client key.
        /// </summary>
        public readonly string Public;
        /// <summary>
        /// Number of events that can be reported within the rate limit window.
        /// </summary>
        public readonly int RateLimitCount;
        /// <summary>
        /// Length of time that will be considered when checking the rate limit.
        /// </summary>
        public readonly int RateLimitWindow;
        /// <summary>
        /// Secret key portion of the client key.
        /// </summary>
        public readonly string Secret;

        [OutputConstructor]
        private GetSentryKeyResult(
            string dsnCsp,

            string dsnPublic,

            string dsnSecret,

            bool? first,

            string id,

            bool isActive,

            string? name,

            string organization,

            string project,

            int projectId,

            string @public,

            int rateLimitCount,

            int rateLimitWindow,

            string secret)
        {
            DsnCsp = dsnCsp;
            DsnPublic = dsnPublic;
            DsnSecret = dsnSecret;
            First = first;
            Id = id;
            IsActive = isActive;
            Name = name;
            Organization = organization;
            Project = project;
            ProjectId = projectId;
            Public = @public;
            RateLimitCount = rateLimitCount;
            RateLimitWindow = rateLimitWindow;
            Secret = secret;
        }
    }
}
