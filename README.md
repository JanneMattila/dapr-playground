# dapr-playground
My random Dapr stuff

```bash
cd src/DaprDemo
dapr run --app-id daprdemo --app-port 5000 --port 3500 dotnet run
```

Make sure you have [Redis](https://github.com/dapr/docs/blob/master/concepts/components/redis.md#creating-a-redis-cache-in-your-kubernetes-cluster-using-helm) 
installed. Grab redis password and update it to the `components/*.yaml` files.

```bash
cd src/DaprDemo
docker build -t daprdemo -f .\Dockerfile.dapr .
cd components
kubectl apply -f .
```
