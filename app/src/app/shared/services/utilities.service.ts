import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { BaseService } from "./base.service";

@Injectable({ providedIn: 'root' })
export class UtilitiesService extends BaseService {
    constructor(private http: HttpClient) {
        super();
    }
    UnflatteringForLeftMenu = (arr: any[]): any[] => {
        const map = {};
        const roots: any[] = [];
        for (let i = 0; i < arr.length; i++) {
            const node = arr[i];
            node.children = [];
            map[node.id] = i; // use map to look-up the parents
            if (node.parent !== null && node.parent != 0) {
                arr[map[node.parent]].children.push(node);
                delete node['children'];
            } else {
                roots.push(node);
            }
        }
        return roots;
    }

    UnflatteringForTree = (arr: any[]): any[] => {
        const map = {};
        const roots: any[] = [];
        let node = {
            data: {
                id: '',
                parent: ''
            },
            expanded: true,
            children: []
        };
        for (let i = 0; i < arr.length; i += 1) {
            map[arr[i].id] = i; // initialize the map
            arr[i].data = arr[i]; // initialize the data
            arr[i].children = []; // initialize the children
        }
        for (let i = 0; i < arr.length; i += 1) {
            node = arr[i];
            if (node.data.parent !== null && arr[map[node.data.parent]] != undefined) {
                arr[map[node.data.parent]].children.push(node);
            } else {
                roots.push(node);
            }
        }
        return roots;
    }

    UnflattenMultiMenu = (arr: any[]): any[] => {
        var tree = [],
            mappedArr = {},
            arrElem,
            mappedElem;

        // First map the nodes of the array to an object -> create a hash table.
        for (var i = 0, len = arr.length; i < len; i++) {
            arrElem = arr[i];
            mappedArr[arrElem.id] = arrElem;
            mappedArr[arrElem.id]['children'] = [];
        }

        for (var id in mappedArr) {
            if (mappedArr.hasOwnProperty(id)) {
                mappedElem = mappedArr[id];
                // If the element is not at the root level, add it to its parent array of children.
                if (mappedElem.parent) {
                    var checkParent = mappedArr[mappedElem['parent']];
                    if (checkParent != undefined && checkParent != null)
                        mappedArr[mappedElem['parent']]['children'].push(mappedElem);
                }
                // If the element is at the root level, add it to first level elements array.
                else {
                    tree.push(mappedElem);
                }
            }
        }
        return tree;
    }
}