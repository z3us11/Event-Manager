# Event-Manager

Generic Unity Event Manager where you can register and unregister events and then trigger them. Helps keep the code well structured.

## How to Use
- Subscribe - CodeArchitecture.EventManager.StartListening<datatype>(CodeArchitecture.EventName, MethodToInvoke)
- Invoke - CodeArchitecture.EventManager.TriggerEvent(CodeArchitecture.EventName, parameters)
