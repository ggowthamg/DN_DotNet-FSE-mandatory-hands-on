import React, { Component } from 'react';

class Posts extends Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  // 🔄 Fetch data
  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(response => response.json())
      .then(data => this.setState({ posts: data }))
      .catch(error => {
        console.error("Error fetching posts:", error);
        this.setState({ hasError: true });
      });
  }

  // ✅ Lifecycle hook
  componentDidMount() {
    this.loadPosts();
  }

  // ❗ Error handling
  componentDidCatch(error, info) {
    alert("Something went wrong while rendering posts.");
    this.setState({ hasError: true });
  }

  // 🖼 Render UI
  render() {
    if (this.state.hasError) {
      return <h2>Error loading posts.</h2>;
    }

    return (
      <div>
        <h1>Blog Posts</h1>
        {this.state.posts.slice(0, 10).map(post => (
          <div key={post.id} style={{ marginBottom: '20px' }}>
            <h3>{post.title}</h3>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}

export default Posts;
