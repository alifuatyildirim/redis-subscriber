using StackExchange.Redis;

const string RedisConnectionString = "localhost:6379";
ConnectionMultiplexer connection=ConnectionMultiplexer.Connect(RedisConnectionString);
const string Channel="channel_one";
var pubsub=connection.GetSubscriber();
pubsub.Subscribe(Channel,(channel,message)=>Console.WriteLine(message));
Console.ReadLine();
