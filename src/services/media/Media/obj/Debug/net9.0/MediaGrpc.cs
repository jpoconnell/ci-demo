// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: media.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Media {
  public static partial class MediaApi
  {
    static readonly string __ServiceName = "media.MediaApi";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Media.GetPreSignedUrlRequest> __Marshaller_media_GetPreSignedUrlRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Media.GetPreSignedUrlRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Media.GetPreSignedUrlReply> __Marshaller_media_GetPreSignedUrlReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Media.GetPreSignedUrlReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Media.GetProductGalleryRequest> __Marshaller_media_GetProductGalleryRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Media.GetProductGalleryRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Media.GetProductGalleryReply> __Marshaller_media_GetProductGalleryReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Media.GetProductGalleryReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Media.GetProductsGalleriesRequest> __Marshaller_media_GetProductsGalleriesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Media.GetProductsGalleriesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Media.GetProductsGalleriesReply> __Marshaller_media_GetProductsGalleriesReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Media.GetProductsGalleriesReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Media.GetPreSignedUrlRequest, global::Media.GetPreSignedUrlReply> __Method_GetPreSignedUrl = new grpc::Method<global::Media.GetPreSignedUrlRequest, global::Media.GetPreSignedUrlReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPreSignedUrl",
        __Marshaller_media_GetPreSignedUrlRequest,
        __Marshaller_media_GetPreSignedUrlReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Media.GetProductGalleryRequest, global::Media.GetProductGalleryReply> __Method_GetProductGallery = new grpc::Method<global::Media.GetProductGalleryRequest, global::Media.GetProductGalleryReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductGallery",
        __Marshaller_media_GetProductGalleryRequest,
        __Marshaller_media_GetProductGalleryReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Media.GetProductsGalleriesRequest, global::Media.GetProductsGalleriesReply> __Method_GetProductsGalleries = new grpc::Method<global::Media.GetProductsGalleriesRequest, global::Media.GetProductsGalleriesReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductsGalleries",
        __Marshaller_media_GetProductsGalleriesRequest,
        __Marshaller_media_GetProductsGalleriesReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Media.MediaReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MediaApi</summary>
    [grpc::BindServiceMethod(typeof(MediaApi), "BindService")]
    public abstract partial class MediaApiBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Media.GetPreSignedUrlReply> GetPreSignedUrl(global::Media.GetPreSignedUrlRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Media.GetProductGalleryReply> GetProductGallery(global::Media.GetProductGalleryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Media.GetProductsGalleriesReply> GetProductsGalleries(global::Media.GetProductsGalleriesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MediaApi</summary>
    public partial class MediaApiClient : grpc::ClientBase<MediaApiClient>
    {
      /// <summary>Creates a new client for MediaApi</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MediaApiClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MediaApi that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public MediaApiClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MediaApiClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected MediaApiClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Media.GetPreSignedUrlReply GetPreSignedUrl(global::Media.GetPreSignedUrlRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPreSignedUrl(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Media.GetPreSignedUrlReply GetPreSignedUrl(global::Media.GetPreSignedUrlRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPreSignedUrl, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Media.GetPreSignedUrlReply> GetPreSignedUrlAsync(global::Media.GetPreSignedUrlRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPreSignedUrlAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Media.GetPreSignedUrlReply> GetPreSignedUrlAsync(global::Media.GetPreSignedUrlRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPreSignedUrl, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Media.GetProductGalleryReply GetProductGallery(global::Media.GetProductGalleryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductGallery(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Media.GetProductGalleryReply GetProductGallery(global::Media.GetProductGalleryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductGallery, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Media.GetProductGalleryReply> GetProductGalleryAsync(global::Media.GetProductGalleryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductGalleryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Media.GetProductGalleryReply> GetProductGalleryAsync(global::Media.GetProductGalleryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductGallery, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Media.GetProductsGalleriesReply GetProductsGalleries(global::Media.GetProductsGalleriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductsGalleries(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Media.GetProductsGalleriesReply GetProductsGalleries(global::Media.GetProductsGalleriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductsGalleries, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Media.GetProductsGalleriesReply> GetProductsGalleriesAsync(global::Media.GetProductsGalleriesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductsGalleriesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Media.GetProductsGalleriesReply> GetProductsGalleriesAsync(global::Media.GetProductsGalleriesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductsGalleries, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override MediaApiClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MediaApiClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(MediaApiBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetPreSignedUrl, serviceImpl.GetPreSignedUrl)
          .AddMethod(__Method_GetProductGallery, serviceImpl.GetProductGallery)
          .AddMethod(__Method_GetProductsGalleries, serviceImpl.GetProductsGalleries).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MediaApiBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetPreSignedUrl, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Media.GetPreSignedUrlRequest, global::Media.GetPreSignedUrlReply>(serviceImpl.GetPreSignedUrl));
      serviceBinder.AddMethod(__Method_GetProductGallery, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Media.GetProductGalleryRequest, global::Media.GetProductGalleryReply>(serviceImpl.GetProductGallery));
      serviceBinder.AddMethod(__Method_GetProductsGalleries, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Media.GetProductsGalleriesRequest, global::Media.GetProductsGalleriesReply>(serviceImpl.GetProductsGalleries));
    }

  }
}
#endregion
