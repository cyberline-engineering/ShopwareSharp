#Invoke-WebRequest https://raw.githubusercontent.com/shopware/store-api-reference/main/storeapi.json -UseBasicParsing -OutFile .\openapi\storeapi.json

#docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli generate -i /local/openapi/storeapi.json -g csharp-netcore -o /local/tmp -c /local/openapi/config.yaml --global-property=apis="Product:Cart:Order:PaymentMethod:PaymentShipping",supportingFiles,models --ignore-file-override=/local/.openapi-generator-ignore
docker run --rm -v ${PWD}:/local openapitools/openapi-generator-cli generate -i /local/storeapi.json -g csharp-netcore -o /local/out -c /local/config.yaml --global-property=apis