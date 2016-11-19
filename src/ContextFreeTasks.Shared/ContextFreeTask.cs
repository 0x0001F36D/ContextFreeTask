﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ContextFreeTasks
{
    [AsyncMethodBuilder(typeof(AsyncContextFreeTaskMethodBuilder))]
    public struct ContextFreeTask
    {
        public Task Task { get; }
        public ContextFreeTask(Task t) => Task = t;
        public ContextFreeTaskAwaiter GetAwaiter() => new ContextFreeTaskAwaiter(Task);
    }
}
