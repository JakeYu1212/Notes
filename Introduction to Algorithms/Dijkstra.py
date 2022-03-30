from pythonds.graphs import PriorityQueue, Graph, Vertex
pq = PriorityQueue()
pq.buildHeap([(4,2),(2,3),(4,5)])
a = pq.delMin()
print(pq)
print(a)
import sys
print(sys.path)