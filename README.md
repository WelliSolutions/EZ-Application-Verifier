# EZ Application Verifier

Can enable the default Application Verifier settings for multiple executables in a directory with a few clicks.

## Default settings

There are 106 Verifier Stops activated by default:

**Exceptions**

```
650 [...] application is trying to run code from an address that is non-executable or free.
```

**Handles**

```
300 [...] invalid handle to system routines
301 [...] invalid TLS index to TLS system routines
302 [...] WaitForMultipleObjects with NULL as the address of the array of handles to wait for or with zero as the number of handles
303 [...] passed a NULL handle to system routines
304 [...] running code inside the DllMain function of one of the DLLs loaded in the current process and it calls WaitForSingleObject or WaitForMultipleObjects
305 [...] calling an API with a handle to an object with an incorrect object type
```

**Heaps**

```
001 Not used right now.
002 [...] Typically it is caused by a buffer overrun error
003 A heap created with HEAP_NO_SERIALIZE flag is not supposed to be accessed simultaneously from two threads
004 [...] HeapAlloc() or HeapReAlloc() operation the size of the block is above any reasonable value
005 Magic value of heap structure destroyed
006 [...] block gets allocated in one heap and freed in another
007 [...] block is freed twice
008 [...] corruption in the heap block
009 [...] try to destroy the default process heap
00A [...] access violation is raised in illegitimate situations
00B [...] cannot determine any particular type of corruption for the block
00C [...] cannot determine any particular type of corruption for the block
00D [...] written to after being freed
00E Freed blocks are sometimes marked non-accessible and a program touching them will access violate
00F [...] buffer overrun errors
010 [...] buffer underruns
011 [...] buffer underruns
012 [...] buffer underruns
013 [...] Typically it is caused by a buffer overrun error
014 [...] while calling GetProcessHeaps the page heap manager detects some internal inconsistencies
```

**Leak**

```
900 [...] owner dll of the allocation was dynamically unloaded while owning resources
901 [...] owner dll of the handle was dynamically unloaded while owning resources
902 [...] owner dll of the registry key was dynamically unloaded while owning resources
903 [...] owner dll of the virtual reservation was dynamically unloaded while owning resources
904 [...] owner dll of the SysString was dynamically unloaded while owning resources
905 [...] dll registered for power notification and was dynamically unloaded without unregistering
906 [...] owner dll of the COM allocation was dynamically unloaded while owning resources
```

**Locks**

```
200 [...] thread is terminated, suspended or is in a state  in which it cannot hold a critical section
201 [...] global variable containing a critical section and the DLL is unloaded but the critical section has not been deleted
202 [...] heap allocation contains a critical section, the allocation is freed and the critical section has not been deleted
203 [...] critical section has been initialized more than one time
204 [...] memory containing a critical section was freed but the critical section has not been deleted
205 [...] DebugInfo field of the critical section is pointing freed memory
206 [...] owner thread ID is invalid in the current context
207 [...] recursion count field of the critical section structure is invalid
208 [...] critical section is owned by a thread if it is deleted or if the critical section is uninitialized
209 [...] critical section is released more times than the current thread acquired it
210 [...] critical section is used without being initialized or after it has been deleted
211 [...] critical section is reinitialized by the current thread
212 [...] current thread is calling VirtualFree on a memory block that contains an active critical section
213 [...] current thread is calling UnmapViewOfFile on a memory block that contains an active critical section
214 [...] calling LeaveCriticalSection but, according to the internal verifier bookkeeping, it doesn't own any critical section
215 [...] current thread tries to use a private lock that lives inside another DLL
```

**Memory**

```
600 [...] VirtualFree or a DLL unload with an invalid start address or size of the memory allocation
601 [...] VirtualAlloc call with an invalid start address or size of the memory allocation
602 [...] MapViewOfFile call with an invalid base address or size of the mapping
603 [...] IsBadXXXPtr call with an invalid address
604 [...] IsBadXXXPtr call for a memory allocation that is free
605 [...] IsBadXXXPtr call for a memory allocation that contains at least one GUARD_PAGE
606 [...] IsBadXXXPtr call with a NULL address
607 [...] IsBadXXXPtr call with an invalid start address or invalid size for the memory buffer to be probed
608 [...] DLL unload with an invalid start address or size of the DLL memory range
609 [...] VirtualFree for a block of memory that is actually part of the current thread's stack
60A [...] VirtualFree with an incorrect value for the FreeType parameter
60B [...] VirtualFree for an address that is already free
60C [...] VirtualFree (MEM_RELEASE) with a non-zero value for the dwSize parameter
60D [...] DllMain function is raising an exception
60E [...] thread function is raising an exception
60F [...] exception during an IsBadXXXPtr call
610 [...] VirtualFree (MEM_RESET) call with a NULL first parameter
612 [...] HeapFree, for a block of memory that is actually part of the current thread's stack
613 [...] UnmapViewOfFile, for a block of memory that is actually part of the current thread's stack
614 [...] use NULL or some other incorrect address as the address of a valid object
615 [...] use NULL or some other incorrect address as the address of a valid object
616 [...] run code from an address that is non-executable or free
617 [...] exception while initializing a buffer specified as output parameter for a Win32 or CRT API
618 [...] calling HeapSize for a heap block that is being freed
619 [...] VirtualFree (MEM_RELEASE) with an lpAddress parameter that is not the base address
61A [...] UnmapViewOfFile with an lpBaseAddress parameter that is not [correct]
61B [...] callback function in the threadpool thread is raising an exception
61C [...] run code from an address that is non-executable or free
61D [...] creating an executable heap
61E [...] allocating executable memory
```

**SRWLock**

```
250 [...] trying to use the SRW lock that is not initialized
251 [...] SRW lock is being re-initialized
252 [...] SRW lock is being released with a wrong release API
253 [...] SRW lock is being acquired recursively by the same thread
254 [...] thread that owns the SRW lock is exiting or being terminated
255 [...] SRW lock is being released by the thread that didn't acquire the lock
256 [...] memory address being freed contains an active SRW lock that is still in use
257 [...] DLL being unloaded contains an active SRW lock that is still in use
```

**ThreadPool**

```
700 [...] thread priority is changed when it's returned to threadpool
701 [...] thread affinity is changed when it's returned to threadpool
702 [...] message left as unprocessed when this threadpool thread is returned to the pool
703 [...] window is kept alive when this threadpool thread is returned to the pool.
704 [...] ExitThread is called on a threadpool thread
705 [...] call back function change the thread token to impersonate another user and forgot to reset it
706 Threadpool thread requiring a persistent thread, e.g. to access TLS
707 [...] call back function forgot to close or reset the current transaction handle
708 [...] call back function calls CoInit and CoUnInit unbalanced
709 [...] period to signal the timer is not zero when the timer is set to signal only once
70A [...] loader lock is held within the callback and is not released when the thread is returned to the threadpool
70B [...] preferred language is set within the callback and is not cleared when the thread is returned to the threadpool
70C [...]  background priority is set within the callback and is not disabled when the thread is returned to the threadpool
70D [...] TerminateThread is called on a threadpool thread
```

**TLS**

```
350 [...] DLL that allocated a TLS index is being unloaded before freeing that TLS index
351 [...] internal verifier structures used to store the state of TLS slots for thread are corrupted
352 [...] invalid TLS index is used
```