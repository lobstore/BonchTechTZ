 Vue.createApp({
            data() {
                return {
                    list:['Открыть блокнот'],
                    interText:''
                }
            },
            computed: {
                listLen: {
                    get: function() {
                        return this.list.length
                    }
                }
            },
            methods: {
                add: function() {
                    this.list.push(this.interText)
                    this.interText = ''
                },
                remove: function() {
                    this.list.splice(this.index,1)
                },
                removeall: function() {
                    this.list = []
                },
            }
        }).mount("#app")